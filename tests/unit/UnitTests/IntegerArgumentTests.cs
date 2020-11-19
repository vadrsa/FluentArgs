using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Args;
using System;

namespace UnitTests
{
	[TestClass]
	public class IntegerArgumentTests
	{
		[TestMethod]
		public void IsGreaterThan_ThrowIfLessThan()
		{
			int integer = 3;

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsGreaterThan(4));

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsGreaterThan(4, "Argument {0} must be greater than {1}"));
		}

		[TestMethod]
		public void IsGreaterThan_ThrowIfEqual()
		{
			int integer = 3;

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsGreaterThan(3));

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsGreaterThan(3, "Argument {0} must be greater than {1}"));
		}

		[TestMethod]
		public void IsGreaterThan_MustNotThrowIfGreater()
		{
			int integer = 3;

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsGreaterThan(2));

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsGreaterThan(2, "Argument {0} must be greater than {1}"));
		}


		[TestMethod]
		public void IsGreaterThanOrEqualTo_ThrowIfLessThan()
		{
			int integer = 3;

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsGreaterThanOrEqualTo(4));

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsGreaterThanOrEqualTo(4, "Argument {0} must be greater than or equal to {1}"));
		}

		[TestMethod]
		public void IsGreaterThanOrEqualTo_MustNotThrowIfEqual()
		{
			int integer = 3;

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsGreaterThanOrEqualTo(3));

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsGreaterThanOrEqualTo(3, "Argument {0} must be greater than or equal to {1}"));
		}


		[TestMethod]
		public void IsGreaterThanOrEqualTo_MustNotThrowIfGreater()
		{
			int integer = 3;

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsGreaterThanOrEqualTo(2));

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsGreaterThanOrEqualTo(2, "Argument {0} must be greater than or equal to {1}"));
		}


		[TestMethod]
		public void IsLessThan_ThrowIfGreaterThan()
		{
			int integer = 3;

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsLessThan(2));

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsLessThan(2, "Argument {0} must be less than {1}"));
		}

		[TestMethod]
		public void IsLessThan_ThrowIfEqual()
		{
			int integer = 3;

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsLessThan(3));

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsLessThan(3, "Argument {0} must be less than {1}"));
		}

		[TestMethod]
		public void IsLessThan_MustNotThrowIfLess()
		{
			int integer = 3;

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsLessThan(4));

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsLessThan(4, "Argument {0} must be less than {1}"));
		}


		[TestMethod]
		public void IsLessThanOrEqualTo_ThrowIfGreaterThan()
		{
			int integer = 3;

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsLessThanOrEqualTo(2));

			Assert.ThrowsException<ArgumentException>(
				() => integer.Arg(nameof(integer)).IsLessThanOrEqualTo(2, "Argument {0} must be less than or equal to {1}"));
		}

		[TestMethod]
		public void IsLessThanOrEqualTo_MustNotThrowIfEqual()
		{
			int integer = 3;

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsLessThanOrEqualTo(3));

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsLessThanOrEqualTo(3, "Argument {0} must be less than or equal to {1}"));
		}


		[TestMethod]
		public void IsLessThanOrEqualTo_MustNotThrowIfLess()
		{
			int integer = 3;

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsLessThanOrEqualTo(4));

			AssertExtensions.DoesNotThrowException(
				() => integer.Arg(nameof(integer)).IsLessThanOrEqualTo(4, "Argument {0} must be less than or equal to {1}"));
		}


	}
}
