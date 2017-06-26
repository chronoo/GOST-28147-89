using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;
using System.Diagnostics;
using System.Threading;

namespace GOSTForTesT
{
	public class Program:Printing
	{
		static void Base(ref UInt32 N1, ref UInt32 N2, UInt32 key, ref byte[,] Table)
		{
			UInt32 S = N1 + key, S1 = 0;
			uint index1;
			for (int i = 0; i < 8; i++)
			{
				index1 = (((S << (28 - i * 4)) >> 28) << 28) >> 28;
				S1 |= (UInt32)Table[i, index1] << i * 4;
			}
			S = S1;
			UInt32 Temp2 = S >> (32 - 11);
			S <<= 11;
			S |= Temp2;
			S = S ^ N2;
			N2 = N1;
			N1 = S;
		}

		static void BaseImit(ref UInt32 N1, ref UInt32 N2, UInt32[] Keys, ref byte[,] Table)
		{
			for (int k = 0; k < 2; k++)
				for (int j = 0; j < 8; j++)
					Base(ref N1, ref N2, Keys[j], ref Table);
		}

		public static string GetImit(string filePath, string keyPath, string tablePath, int cashSize=10000)
		{
			FileInfo info;
			FileStream fs;
			Stopwatch SW = new Stopwatch();
			byte[] S = new byte[8];
			string keyName = @keyPath;
			info = new FileInfo(keyName);
			byte[] keys = new byte[info.Length];
			fs = new FileStream(keyName, FileMode.Open, FileAccess.Read);
			fs.Read(keys, 0, (int)info.Length);
			UInt32[] keyArray = new UInt32[8];
			for (int i = 0; i < 8; i++)
				keyArray[i] = BitConverter.ToUInt32(keys, i * 4);
			string tableName = @tablePath;
			string[] tableHex = System.IO.File.ReadAllLines(tableName, Encoding.Default);
			string[,] s1_hex = new string[8, 16];
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 16; j++)
					s1_hex[i, j] = tableHex[i][j].ToString();
			byte[,] Table = new byte[8, 16];
			BitArray bi = new BitArray(8);
			BitArray bi1 = new BitArray(4);
			for (int k = 0; k < 8; k++)
				for (int i = 0; i < 16; i++)
					Table[k, i] = byte.Parse(s1_hex[k, i], System.Globalization.NumberStyles.AllowHexSpecifier);

			info = new FileInfo(@filePath);
			long filesize = info.Length;
			if (filesize % 8 != 0) filesize = (filesize / 8 + 1) * 8;
			DateTime localDate = DateTime.Now;
			CultureInfo culture = new CultureInfo("ru-RU");
			fs = new FileStream(@filePath, FileMode.Open, FileAccess.Read);
			UInt32 N1 = 0, N2 = 0, T1, T2;
			byte[] temtT = new byte[8];
			byte[] cash = new byte[cashSize * 8];
			for (int m = 0; m < filesize / 8; m++)
			{
				if (m % cashSize == 0)
				{
					cash = new byte[cashSize * 8];
					fs.Read(cash, 0, cashSize * 8);
				}
				Buffer.BlockCopy(cash, (m % cashSize) * 8, temtT, 0, 8);
				T1 = BitConverter.ToUInt32(temtT, 0);
				T2 = BitConverter.ToUInt32(temtT, 4);
				N1 = N1 ^ T1;
				N2 = N2 ^ T2;
				BaseImit(ref N1, ref N2, keyArray, ref Table);
			}
			string hash = getImit(N2);
			string report = localDate.ToString(culture) + " " + @filePath + " (" + info.Length + " байт) " + "\nХэш: " + hash;
			StreamWriter sw = new StreamWriter(@"D:\GOST\hash.txt", true, System.Text.Encoding.Default);
			sw.WriteLine(report);
			sw.Close();
			return hash;
		}

		static void Main()
		{
			Console.WriteLine(GetImit(@"D:\GOST\test\3",@"D:\GOST\key",@"D:\GOST\table"));
			Console.ReadKey();
		}

		static string getImit(UInt32 Block)
		{			
			string hashTemp = BitConverter.ToString(BitConverter.GetBytes(Block)).Replace("-", "");
			string hash = "";
			for (int i = hashTemp.Length / 2 - 1; i >= 0; i--)
			{
				hash += hashTemp.Substring(i * 2, 2);
			}
			return hash;
		}		
	}
}
