using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Args;
using System;

namespace UnitTests
{
	[TestClass]
	public class GenericArgumentTests
	{
		[TestMethod]
		public void IsNotNull_MustThrowIfNull()
		{
			string nullStr = null;

			Assert.ThrowsException<ArgumentNullException>(() =>
				nullStr.Arg(nameof(nullStr)).IsNotNull());

			Assert.ThrowsException<ArgumentNullException>(() =>
				nullStr.Arg(nameof(nullStr)).IsNotNull("Argument {0} cannot be null"));
		}

		[TestMethod]
		public void IsNotNull_MustNotThrowIfNotNull()
		{
			string str = "test";

			AssertExtensions.DoesNotThrowException(() =>
				str.Arg(nameof(str)).IsNotNull());

			AssertExtensions.DoesNotThrowException(() =>
				str.Arg(nameof(str)).IsNotNull("Argument {0} cannot be null"));
		}

		[TestMethod]
		public void IsNotDefault_MustThrowIfDefault()
		{
			Assert.ThrowsException<ArgumentException>(
				() => 0.Arg("test int").IsNotDefault());

			Assert.ThrowsException<ArgumentException>(
				() => 0.Arg("test int").IsNotDefault("Argument {0} must not be default"));
		}

		[TestMethod]
		public void IsNotDefault_MustNotThrowIfNotDefault()
		{
			AssertExtensions.DoesNotThrowException(
				() => 1.Arg("test int").IsNotDefault());

			AssertExtensions.DoesNotThrowException(
				() => 1.Arg("test int").IsNotDefault("Argument {0} must not be default"));
		}

		[TestMethod]
		public void Is_MustNotThrowIfReturnsTrue()
		{
			Func<int, bool> predicate = _ => true;

			AssertExtensions.DoesNotThrowException(
				() => 0.Arg("test int").Is(predicate));

			AssertExtensions.DoesNotThrowException(
				() => 0.Arg("test int").Is(predicate, "Argument {0} must pass the predicate"));
		}

		[TestMethod]
		public void Is_MustThrowIfReturnsFalse()
		{
			Func<int, bool> predicate = _ => false;

			Assert.ThrowsException<ArgumentException>(
				() => 0.Arg("test int").Is(predicate));

			Assert.ThrowsException<ArgumentException>(
				() => 0.Arg("test int").Is(predicate, "Argument {0} must fail the predicate"));
		}
	}
}
