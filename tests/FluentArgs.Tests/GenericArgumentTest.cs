
namespace UnitTests
{
	public class GenericArgumentTests
	{
		[Fact]
		public void IsNotNull_MustThrowIfNull()
		{
			string nullStr = null;

			var execute = () => nullStr.Arg(nameof(nullStr)).IsNotNull();
			execute.Should().ThrowExactly<ArgumentNullException>();
			
			var executeWithMessage = () => nullStr.Arg(nameof(nullStr)).IsNotNull("Argument {0} cannot be null");
			executeWithMessage.Should().ThrowExactly<ArgumentNullException>();
		}

		[Fact]
		public void IsNotNull_MustNotThrowIfNotNull()
		{
			var str = "test";

			var execute = () => str.Arg(nameof(str)).IsNotNull();
			execute.Should().NotThrow<ArgumentNullException>();
			
			var executeWithMessage = () => str.Arg(nameof(str)).IsNotNull("Argument {0} cannot be null");
			executeWithMessage.Should().NotThrow<ArgumentNullException>();
		}

		[Fact]
		public void IsNotDefault_MustThrowIfDefault()
		{
			var execute = () => 0.Arg("test int").IsNotDefault();
			execute.Should().ThrowExactly<ArgumentException>();
			
			var executeWithMessage = () => 0.Arg("test int").IsNotDefault("Argument {0} must not be default");
			executeWithMessage.Should().ThrowExactly<ArgumentException>();
		}

		[Fact]
		public void IsNotDefault_MustNotThrowIfNotDefault()
		{
			var execute = () => 1.Arg("test int").IsNotDefault();
			execute.Should().NotThrow<ArgumentException>();
			
			var executeWithMessage = () => 1.Arg("test int").IsNotDefault("Argument {0} must not be default");
			executeWithMessage.Should().NotThrow<ArgumentException>();
		}

		[Fact]
		public void Is_MustNotThrowIfReturnsTrue()
		{
			Func<int, bool> predicate = _ => true;

			var execute = () => 0.Arg("test int").Is(predicate);
			execute.Should().NotThrow<ArgumentException>();
			
			var executeWithMessage = () => 0.Arg("test int").Is(predicate, "Argument {0} must pass the predicate");
			executeWithMessage.Should().NotThrow<ArgumentException>();
		}

		[Fact]
		public void Is_MustThrowIfReturnsFalse()
		{
			Func<int, bool> predicate = _ => false;

			
			var execute = () => 0.Arg("test int").Is(predicate);
			execute.Should().ThrowExactly<ArgumentException>();
			
			var executeWithMessage = () => 0.Arg("test int").Is(predicate, "Argument {0} must fail the predicate");
			executeWithMessage.Should().ThrowExactly<ArgumentException>();
		}
	}
}
