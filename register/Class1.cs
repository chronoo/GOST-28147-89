using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register
{
	class Class1
	{
		public string GOST(string path, int len = 32)
		{
			byte[] M = new byte[8];
			byte[] N1 = new byte[4];
			byte[] N2 = new byte[4];
			string tableName = @"D:\prog\gost 0.2\table.txt";
			string[] tableHex = System.IO.File.ReadAllLines(tableName, Encoding.UTF8);
			string[] s1_hex = new string[8];
			for (int i = 0; i < 8; i++)
				s1_hex[i] = tableHex[0].Substring(i * 2, 2);
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
			byte[] buffer = new byte[((Encoding.UTF8.GetByteCount(path) / 8) + 1) * 8];
			Encoding.UTF8.GetBytes(path, 0, path.Length, buffer, 0);
			Buffer.BlockCopy(buffer, 0, M, 0, 8);
			for (int m = 1; m < buffer.Length / 8 + 1; m++)
			{
				Buffer.BlockCopy(M, 0, N1, 0, 4);
				Buffer.BlockCopy(M, 4, N2, 0, 4);
				for (int l = 0; l < 16; l++)
				{
					Buffer.BlockCopy(N1, 0, N2, 0, 4);
					UInt32 summ_ = BitConverter.ToUInt32(N1, 0);
					BitArray codedBlock = new BitArray(32);
					for (int i = 0; i < 8; i++)
					{
						uint index = (summ_ << 28 - i * 4) >> 28;
						for (int j = 0; j < 4; j++)
							codedBlock[i * 4 + j] = S[index].Get(j);
					}
					BitArray bufferBlock = new BitArray(32);
					for (int i = 0; i < 32; i++)
						bufferBlock[i] = codedBlock[(i - 11 + 32) % 32];
					bufferBlock = bufferBlock.Xor(new BitArray(N2));
					bufferBlock.CopyTo(N1, 0);
				}

				if (m < buffer.Length / 8)
				{
					Buffer.BlockCopy(buffer, m * 8, M, 0, 8);
					byte[] textBlock = new byte[8];
					Buffer.BlockCopy(N1, 0, textBlock, 0, 4);
					Buffer.BlockCopy(N2, 0, textBlock, 4, 4);
					BitArray MBit = new BitArray(M);
					BitArray textBlockBit = new BitArray(textBlock);
					MBit = MBit.Xor(textBlockBit);
					MBit.CopyTo(M, 0);
				}
				else
				{
					Buffer.BlockCopy(N1, 0, M, 0, 4);
					Buffer.BlockCopy(N2, 0, M, 4, 4);
				}
			}
			UInt32 imit = BitConverter.ToUInt32(M, 0);
			imit = (imit << (32 - len)) >> (32 - len);
			string hash = BitConverter.ToString(BitConverter.GetBytes(imit), 0, (len - 1) / 8 + 1).Replace("-", "");
			return hash;
		}
	}
}