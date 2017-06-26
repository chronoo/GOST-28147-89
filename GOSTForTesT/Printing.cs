using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOSTForTesT
{
	public class Printing
	{
		public static void print(BitArray q, string text = "")
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

		public static void print(byte[] b, string text = "")
		{
			BitArray q = new BitArray(b);
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

		public static void print(UInt32 b, string text = "")
		{
			print(BitConverter.GetBytes(b), text);
		}

		public static void print(byte b, string text = "")
		{
			BitArray q = new BitArray(b);
			for (int i = 0; i < q.Length; i++)
				if (q.Get(i))
					Console.Write(1);
				else
					Console.Write(0);
			Console.WriteLine(text);
		}
		public static void printHex(byte[] b, string text = "")
		{
			string Hex = BitConverter.ToString(b).Replace("-", "");
			for (int i = 0; i < Hex.Length / 2; i++)
				Console.Write(Hex[i * 2 + 1] + "" + Hex[i * 2] + " ");
			Console.WriteLine(text);
		}

		public static void printHex(UInt32 b, string text = "")
		{
			printHex(BitConverter.GetBytes(b), text);
		}

		public static void printHex(BitArray b, string text = "")
		{
			byte[] a = new byte[b.Length / 8];
			b.CopyTo(a, 0);
			printHex(a, text);
		}
	}
}
