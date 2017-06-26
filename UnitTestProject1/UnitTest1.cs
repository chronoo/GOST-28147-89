using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GOSTForTesT;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			string hash=Program.GetImit(@"D:\GOST\test\1", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "00000000");
		}

		[TestMethod]
		public void TestMethod2()
		{
			string hash = Program.GetImit(@"D:\GOST\test\2", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "6D465ED3");
		}

		[TestMethod]
		public void TestMethod3()
		{
			string hash = Program.GetImit(@"D:\GOST\test\3", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "9E320F66");
		}

		[TestMethod]
		public void TestMethod4()
		{
			string hash = Program.GetImit(@"D:\GOST\test\4", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "E924E555");
		}

		[TestMethod]
		public void TestMethod5()
		{
			string hash = Program.GetImit(@"D:\GOST\test\5", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "5F8C290C");
		}

		[TestMethod]
		public void TestMethod6()
		{
			string hash = Program.GetImit(@"D:\GOST\test\6", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "49417D7A");
		}

		[TestMethod]
		public void TestMethod7()
		{
			string hash = Program.GetImit(@"D:\GOST\test\7", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "A70794E1");
		}

		[TestMethod]
		public void TestMethod8()
		{
			string hash = Program.GetImit(@"D:\GOST\test\8", @"D:\GOST\key", @"D:\GOST\table");
			Assert.AreEqual(hash, "D8C16213");
		}

		[TestMethod]
		public void TestMethod10()
		{
			string hash = Program.GetImit(@"D:\GOST\test\10", @"D:\GOST\key", @"D:\GOST\table2");
			Assert.AreEqual(hash,"input error");
		}

		[TestMethod]
		public void TestMethod11()
		{
			string hash = Program.GetImit(@"D:\GOST\test\11", @"D:\GOST\key", @"D:\GOST\table3");
			Assert.AreEqual(hash, "input error");
		}

		[TestMethod]
		public void TestMethod12()
		{
			string hash = Program.GetImit(@"D:\GOST\test\12", @"D:\GOST\key2", @"D:\GOST\table");
			Assert.AreEqual(hash, "input error");
		}

		[TestMethod]
		public void TestMethod13()
		{
			string hash = Program.GetImit(@"D:\GOST\test\13", @"D:\GOST\key3", @"D:\GOST\table");
			Assert.AreEqual(hash, "input error");
		}

		[TestMethod]
		public void TestMethod14()
		{
			string hash = Program.GetImit(@"D:\GOST\test\14", @"D:\GOST\key", @"D:\GOST\table5");
			Assert.AreEqual(hash, "input error");
		}
		
		
		/*[TestMethod]
		public void TestMethod9()
		{
			string hash = Program.GetImit(@"D:\programms\ru_sql_server_2014_business_intelligence_with_service_pack_1_x64_dvd_6668526.iso", @"D:\GOST\key", @"D:\GOST\table",4000000);
			Assert.AreEqual(hash, "D152C8D1");
		}*/
	}
}
