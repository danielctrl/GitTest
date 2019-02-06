using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestAdd()
		{
			int expected = 5;
			int a = 3;
			int b = 2;


			int actual = Program.Sum(a, b);


			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BrokenTestAdd()
		{
			int expected = 6;
			int a = 3;
			int b = 2;


			int actual = Program.Sum(a, b);


			Assert.AreEqual(expected, actual);
		}
	}
}
