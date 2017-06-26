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

namespace gost_0._1
{
	class Program
	{
		static void Base(ref UInt32 N1, ref UInt32 N2, UInt32 key, ref byte[,] Table)
		{
			UInt32 S = N1 + key,S1=0;
			uint index1;
			for (int i = 0; i < 8; i++)
			{
				index1 = (((S << (28 - i *4)) >> 28) << 28) >> 28;
				S1 |= (UInt32)Table[i, index1] << i*4;
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
			for(int k=0;k<2;k++)
				for (int j = 0; j < 8; j++)
					Base(ref N1, ref N2, Keys[j], ref Table);
		}
		
		static void Main(string[] args)
		{
			string[] fileNames = System.IO.File.ReadAllLines(@"D:\GOST\path.txt", Encoding.Default);
			FileInfo info;
			FileStream fs;
			Stopwatch SW = new Stopwatch();
			byte[] S = new byte[8];
			string keyName = @"D:\GOST\key";
			info = new FileInfo(keyName);
			byte[] keys = new byte[info.Length];
			fs = new FileStream(keyName, FileMode.Open, FileAccess.Read);
			fs.Read(keys, 0, (int)info.Length);
			UInt32[] keyArray = new UInt32[8];
			for (int i = 0; i < 8; i++)
				keyArray[i] = BitConverter.ToUInt32(keys, i * 4);
			string tableName = @"D:\GOST\table";
			string[] tableHex = System.IO.File.ReadAllLines(tableName, Encoding.Default);
			string[,] s1_hex = new string[8,16];
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 16; j++)
				s1_hex[i,j] = tableHex[i][j].ToString();
			byte[,] Table = new byte[8, 16];
			BitArray bi = new BitArray(8);
			BitArray bi1 = new BitArray(4);
			for (int k = 0; k < 8; k++)
				for (int i = 0; i < 16; i++)				
				{
					byte hexNum =byte.Parse(s1_hex[k,i], System.Globalization.NumberStyles.AllowHexSpecifier);
					Table[k, i] = hexNum;		
				}
			foreach (string path in fileNames)
			{
				info = new FileInfo(path);
				long filesize = info.Length;
				if (filesize % 8 != 0) filesize = (filesize / 8+1)*8;
				byte[] buffer = new byte[8];
				DateTime localDate = DateTime.Now;
				CultureInfo culture = new CultureInfo("ru-RU");
				fs = new FileStream(path, FileMode.Open, FileAccess.Read);
				//fs.Read(buffer, 0, (int)info.Length);
				UInt32 N1 = 0, N2 = 0, T1, T2;
				byte[] temtT = new byte[8];
				int cashSize = 4000000;
				byte[] cash = new byte[cashSize * 8];
				Console.WriteLine(localDate.ToString(culture) + " " + path + " (" + info.Length + " байт) ");
				for (int m = 0; m < filesize / 8; m++)
				{
					if (m % cashSize == 0)
					{
						Console.Write("Готово: {0:0.00}%\n", ((double)m * 100 * 8 / filesize));
						cash = new byte[cashSize * 8];
						fs.Read(cash, 0, cashSize * 8);
						Console.CursorTop--;
					}
					Buffer.BlockCopy(cash, (m % cashSize) * 8, temtT, 0, 8);
					T1 = BitConverter.ToUInt32(temtT,0);
					T2 = BitConverter.ToUInt32(temtT, 4);
					N1 = N1 ^ T1;
					N2 = N2 ^ T2;
					BaseImit(ref N1, ref N2, keyArray, ref Table);	
				}
				string hash = getImit(N2);
				string report = localDate.ToString(culture) + " " + path + " (" + info.Length + " байт) " + "\nХэш: " + hash;
				Console.WriteLine("Хэш: " + hash);
				StreamWriter sw = new StreamWriter(@"D:\GOST\hash.txt", true, System.Text.Encoding.Default);
				sw.WriteLine(report);
				sw.Close();
			}
			Console.ReadKey();
		}

		static string getImit(UInt32 Block)
		{
			string hashTemp = BitConverter.ToString(BitConverter.GetBytes(Block)).Replace("-", "");
			string hash = "";
			for (int i = hashTemp.Length/2-1; i>=0 ; i--)
			{
				hash+=hashTemp.Substring(i*2,2);
				if (i > 0) hash += "-";
			}
			return hash;
		}

		static void print(BitArray q, string text = "")
		{
			for (int i = 0; i < q.Length; i++)
			{
				if (q.Get(i))
					Console.Write(1);
				else
					Console.Write(0);
				if (i % 4 == 3 || i == q.Length - 1) Console.Write(" ");
			}
			Console.WriteLine(text);
		}

		static void print(byte[] b, string text = "")
		{
			BitArray q = new BitArray(b);
			for (int i = 0; i < q.Length; i++)
			{
				if (q.Get(i))
					Console.Write(1);
				else
					Console.Write(0);
				if (i % 4 == 3 || i == q.Length-1) Console.Write(" ");
			}
			Console.WriteLine(text);
		}

		static void print(UInt32 b, string text = "")
		{
			print(BitConverter.GetBytes(b), text);
		}

		static void print(byte b, string text = "")
		{
			BitArray q = new BitArray(b);
			for (int i = 0; i < q.Length; i++)
				if (q.Get(i))
					Console.Write(1);
				else
					Console.Write(0);
			Console.WriteLine(text);
		}
		static void printHex(byte[] b, string text = "")
		{
			string Hex = BitConverter.ToString(b).Replace("-", "");
			for(int i=0;i<Hex.Length/2;i++)
				Console.Write(Hex[i*2+1]+""+Hex[i*2]+" ");
			Console.WriteLine(text);
		}

		static void printHex(UInt32 b, string text = "")
		{
			printHex(BitConverter.GetBytes(b), text);
		}

		static void printHex(BitArray b, string text = "")
		{
			byte[] a=new byte[b.Length/8];
			b.CopyTo(a, 0);
			printHex(a, text);
		}
	}
}
