using Microsoft.Extensions.Args;

namespace FluentArgsConsole
{
	class Test
	{
		public Test(string testString, int testInt)
			=> Argument.Inline(
				testString.Arg(nameof(testString)).IsNotNullOrEmpty(),
				testInt.Arg(nameof(testInt)).IsNotNull().Is(i => i > 3, "Argument {0} cannot be lower than or equal to 3")
			);
		
	}
}
