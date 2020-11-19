using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Args;
using System;

namespace UnitTests
{
	[TestClass]
	public class StringArgumentTests
	{
		[TestMethod]
		public void IsNotNullOrEmpty_ThrowIfNull()
		{
			string nullStr = null;

			Assert.ThrowsException<ArgumentException>(
				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrEmpty());

			Assert.ThrowsException<ArgumentException>(
				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrEmpty("Argument {0} must fail because it is null"));
		}


		[TestMethod]
		public void IsNotNullOrEmpty_ThrowIfEmpty()
		{
			string emptyStr = "";

			Assert.ThrowsException<ArgumentException>(
				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrEmpty());

			Assert.ThrowsException<ArgumentException>(
				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrEmpty("Argument {0} must fail because it is empty"));
		}


		[TestMethod]
		public void IsNotNullOrWhitespace_ThrowIfNull()
		{
			string nullStr = null;

			Assert.ThrowsException<ArgumentException>(
				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrWhitespace());

			Assert.ThrowsException<ArgumentException>(
				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrWhitespace("Argument {0} must fail because it is null"));
		}

		[TestMethod]
		public void IsNotNullOrWhitespace_ThrowIfEmpty()
		{
			string emptyStr = null;

			Assert.ThrowsException<ArgumentException>(
				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrWhitespace());

			Assert.ThrowsException<ArgumentException>(
				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrWhitespace("Argument {0} must fail because it is empty"));
		}

		[TestMethod]
		public void IsNotNullOrWhitespace_ThrowIfWhitespace()
		{
			string wsStr = " ";

			Assert.ThrowsException<ArgumentException>(
				() => wsStr.Arg(nameof(wsStr)).IsNotNullOrWhitespace());

			Assert.ThrowsException<ArgumentException>(
				() => wsStr.Arg(nameof(wsStr)).IsNotNullOrWhitespace("Argument {0} must fail because it is whitespace"));
		}
	}
}
