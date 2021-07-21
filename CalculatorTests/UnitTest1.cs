using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace TestSample
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
			calc = new Calculator();
		}

		[Test]
		public void Add()
		{
			Assert.AreEqual(3, calc.Add(1, 2));
		}

		private Calculator calc;
	}
}