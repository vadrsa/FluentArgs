using System;
using System.Diagnostics;

namespace Microsoft.Extensions.Args
{
	/// <summary>
	/// Extension methods for <see cref="Argument{string}"/> of type string
	/// </summary>
	public static class StringArgumentExtensions
	{
		/// <summary>
		/// Validate that the argument is not null or empty
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		[DebuggerStepThrough]
		public static Argument<string> IsNotNullOrEmpty(this Argument<string> argument) => 
			argument.IsNotNullOrEmpty("String argument {0} cannot be null or empty.");

		/// <summary>
		/// Validate that the argument is not null or empty
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<string> IsNotNullOrEmpty(this Argument<string> argument, string message)
		{
			if (string.IsNullOrEmpty(argument.Value))
			{
				throw new ArgumentException(string.Format(message, argument.Name));
			}
			return argument;
		}


		/// <summary>
		/// Validate that the argument is not null, empty and doesn't consist only of white-space characters
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		[DebuggerStepThrough]
		public static Argument<string> IsNotNullOrWhitespace(this Argument<string> argument) => 
			argument.IsNotNullOrWhitespace("String argument {0} cannot be null, empty, or consist only of white-space characters.");

		/// <summary>
		/// Validate that the argument is not null, empty and doesn't consist only of white-space characters
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<string> IsNotNullOrWhitespace(this Argument<string> argument, string message)
		{
			if (string.IsNullOrWhiteSpace(argument.Value))
			{
				throw new ArgumentException(string.Format(message, argument.Name));
			}
			return argument;
		}
	}
}
