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

namespace register
{
	public class Hash
	{
		public string GOST(string path, int len = 32)
		{
			int m = 0;
			string hash;
			//string[] fileNames = System.IO.File.ReadAllLines(@"D:\prog\gost 0.2\path.txt", Encoding.Default);//@"D:\genymotion-player.log";
			FileInfo info;
			FileStream fs;
			Stopwatch SW = new Stopwatch();
			byte[] M = new byte[8];
			byte[] N1 = new byte[4];
			byte[] N2 = new byte[4];
			string keyName = @"D:\prog\gost 0.2\key.txt";
			info = new FileInfo(keyName);
			byte[] keys = new byte[info.Length];
			fs = new FileStream(keyName, FileMode.Open, FileAccess.Read);
			fs.Read(keys, 0, (int)info.Length);
			UInt32[] keyArray = new UInt32[8];
			for (int i = 0; i < 8; i++)
				keyArray[i] = BitConverter.ToUInt32(keys, i * 4);
			string tableName = @"D:\prog\gost 0.2\table.txt";
			string[] tableHex = System.IO.File.ReadAllLines(tableName, Encoding.UTF8);
			string[] s1_hex = new string[8];// keys_hex[0].Substring(0, 2);
			for (int i = 0; i < 8; i++)
			{
				s1_hex[i] = tableHex[0].Substring(i * 2, 2);
			}
			BitArray[] S = new BitArray[16];
			BitArray bi = new BitArray(8);
			BitArray bi1 = new BitArray(4);
			BitArray bi2 = new BitArray(4);
			for (int i = 0; i < 8; i++)
			{
				byte hexNum = byte.Parse(s1_hex[i], System.Globalization.NumberStyles.HexNumber);
				bi = new BitArray(BitConverter.GetBytes(hexNum).ToArray());

				for (int j = 0; j < 4; j++)
				{
					bi1[j] = bi[j];
					bi2[j] = bi[j + 4];
				}
				S[2 * i] = new BitArray(bi2);
				S[2 * i + 1] = new BitArray(bi1);
			}
			//foreach (string path in args)
			{
				/*procc_num++;
				SW.Start(); // Запускаем*/
				//info = new FileInfo(path);
				//byte[] buffer = new byte[((path.Length / 8) + 1) * 8+1000];
				byte[] buffer = new byte[((Encoding.UTF8.GetByteCount(path) / 8) + 1) * 8];

				//print(buffer," - buffer");

				/*DateTime localDate = DateTime.Now;
				CultureInfo culture = new CultureInfo("ru-RU");*/
				//Console.WriteLine(localDate.ToString(culture) + " " + path + " (" + info.Length + " байт)");

				//fs = new FileStream(path, FileMode.Open, FileAccess.Read);
				//fs.Read(buffer, 0, (int)path.Length);
				Encoding.UTF8.GetBytes(path, 0, path.Length, buffer, 0);

				//print(buffer, " - buffer");

				Buffer.BlockCopy(buffer, 0, M, 0, 8);

				/*Thread proc = new Thread(delegate() { progress((int)info.Length,procc_num); });
				proc.Start();*/

				for (m = 1; m < buffer.Length / 8 + 1; m++)
				{
					Buffer.BlockCopy(M, 0, N1, 0, 4);
					Buffer.BlockCopy(M, 4, N2, 0, 4);
					for (int l = 0; l < 16; l++)
					{
						Buffer.BlockCopy(N1, 0, N2, 0, 4);
						UInt32 summ_ = BitConverter.ToUInt32(N1, 0);
						UInt32 key_ = keyArray[l % 8];
						//summ_ += key_;          строка с суммированием ключа              
						BitArray q = new BitArray(BitConverter.GetBytes(summ_));
						BitArray codedBlock = new BitArray(32);
						for (int i = 0; i < 8; i++)
						{
							uint index = (summ_ << 28 - i * 4) >> 28;
							for (int j = 0; j < 4; j++)
								codedBlock[i * 4 + j] = S[index].Get(j);
						}

						BitArray bufferBlock = new BitArray(32);
						for (int i = 0; i < 32; i++)
							bufferBlock[i] = codedBlock[(i - 11 + 32) % 32];//циклический сдвиг на 11 разрядов влево
						//print(bufferBlock);
						//if (m == 2 && l == 1) print(bufferBlock);
						bufferBlock = bufferBlock.Xor(new BitArray(N2));//XOR
						bufferBlock.CopyTo(N1, 0);
					}

					if (m < buffer.Length / 8) //(buffer.Length > 8)
					{
						//print(buffer);
						Buffer.BlockCopy(buffer, m * 8, M, 0, 8);
						byte[] textBlock = new byte[8];
						Buffer.BlockCopy(N1, 0, textBlock, 0, 4);
						Buffer.BlockCopy(N2, 0, textBlock, 4, 4);
						//print(textBlock);
						BitArray MBit = new BitArray(M);
						BitArray textBlockBit = new BitArray(textBlock);
						MBit = MBit.Xor(textBlockBit);
						MBit.CopyTo(M, 0);
						//print(M);
					}
					else
					{
						Buffer.BlockCopy(N1, 0, M, 0, 4);
						Buffer.BlockCopy(N2, 0, M, 4, 4);
						//print(M);
					}
				}
				/*SW.Stop(); //Останавливаем                
				Console.CursorTop--;
				localDate = DateTime.Now;*/
				UInt32 imit = BitConverter.ToUInt32(M, 0);
				imit = (imit << (32 - len)) >> (32 - len);
				hash = BitConverter.ToString(BitConverter.GetBytes(imit), 0, (len - 1) / 8 + 1).Replace("-", "");
				//string report = localDate.ToString(culture) + " " + path + " (" + path.Length + " байт) " + "\nХэш: " + hash + " \nВремя: " + Convert.ToString(SW.ElapsedMilliseconds) + " мс";
				/*Console.WriteLine(report);
				Console.WriteLine("Скорость хэширования: {0:0.00}  КБайт/с\n", (double)((double)info.Length / 1024) / ((double)SW.ElapsedMilliseconds / 1000));*/

				/*StreamWriter sw = new StreamWriter(@"D:\prog\gost 0.2\hash.txt", true, System.Text.Encoding.Default);
				sw.WriteLine(report);
				sw.Close();*/
			}
			//Console.ReadKey();
			return hash;
		}

		static void print(byte[] b, string text = "")
		{
			BitArray q = new BitArray(b);
			for (int i = q.Count - 1; i >= 0; i--)
			{
				if (q.Get(i))
					Console.Write(1);
				else
					Console.Write(0);
				if (i % 4 == 0 && q.Count - i > 1) Console.Write(" ");
			}
			Console.WriteLine(text);
		}

		static void print(BitArray q, string text = "")
		{
			for (int i = q.Count - 1; i >= 0; i--)
			{
				if (q.Get(i))
					Console.Write(1);
				else
					Console.Write(0);
				if (i % 4 == 0 && q.Count - i > 1) Console.Write(" ");
			}
			Console.WriteLine(text);
		}

	}
}