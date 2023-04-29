// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Microsoft.Extensions.Args;
// using System;
//
// namespace UnitTests
// {
// 	public class StringArgumentTests
// 	{
// 		[Fact]
// 		public void IsNotNullOrEmpty_ThrowIfNull()
// 		{
// 			string nullStr = null;
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrEmpty());
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrEmpty("Argument {0} must fail because it is null"));
// 		}
//
//
// 		[Fact]
// 		public void IsNotNullOrEmpty_ThrowIfEmpty()
// 		{
// 			string emptyStr = "";
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrEmpty());
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrEmpty("Argument {0} must fail because it is empty"));
// 		}
//
// 		[Fact]
// 		public void IsNotNullOrEmpty_MustNotThrowIfNotEmpty()
// 		{
// 			string str1 = "    ";
//
// 			AssertExtensions.DoesNotThrowException(() =>
// 				str1.Arg(nameof(str1)).IsNotNullOrEmpty());
//
//
// 			AssertExtensions.DoesNotThrowException(() =>
// 				str1.Arg(nameof(str1)).IsNotNullOrEmpty("Argument {0} cannot be null or empty"));
//
// 			string str2 = "test";
//
// 			AssertExtensions.DoesNotThrowException(() =>
// 				str2.Arg(nameof(str2)).IsNotNullOrEmpty());
//
// 			AssertExtensions.DoesNotThrowException(() =>
// 				str2.Arg(nameof(str2)).IsNotNullOrEmpty("Argument {0} cannot be null or empty"));
// 		}
//
// 		[Fact]
// 		public void IsNotNullOrWhitespace_ThrowIfNull()
// 		{
// 			string nullStr = null;
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrWhitespace());
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => nullStr.Arg(nameof(nullStr)).IsNotNullOrWhitespace("Argument {0} must fail because it is null"));
// 		}
//
// 		[Fact]
// 		public void IsNotNullOrWhitespace_ThrowIfEmpty()
// 		{
// 			string emptyStr = null;
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrWhitespace());
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => emptyStr.Arg(nameof(emptyStr)).IsNotNullOrWhitespace("Argument {0} must fail because it is empty"));
// 		}
//
// 		[Fact]
// 		public void IsNotNullOrWhitespace_ThrowIfWhitespace()
// 		{
// 			string wsStr = " ";
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => wsStr.Arg(nameof(wsStr)).IsNotNullOrWhitespace());
//
// 			Assert.ThrowsException<ArgumentException>(
// 				() => wsStr.Arg(nameof(wsStr)).IsNotNullOrWhitespace("Argument {0} must fail because it is whitespace"));
// 		}
//
// 		[Fact]
// 		public void IsNotNullOrWhitespace_MustNotThrowIfNotEmpty()
// 		{
// 			string str = "  test  ";
//
// 			AssertExtensions.DoesNotThrowException(() =>
// 				str.Arg(nameof(str)).IsNotNullOrWhitespace());
//
//
// 			AssertExtensions.DoesNotThrowException(() =>
// 				str.Arg(nameof(str)).IsNotNullOrWhitespace("Argument {0} cannot be null or empty, or whitespace"));
// 		}
// 	}
// }
