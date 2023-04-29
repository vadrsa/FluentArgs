using System;
using System.Diagnostics;

namespace FluentArgs
{
	/// <summary>
	/// Extension methods for <see cref="Argument{int}"/>
	/// </summary>
	public static class IntegerExtensions
	{
		/// <summary>
		/// Validate that the argument is greater than some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		[DebuggerStepThrough]
		public static Argument<int> IsGreaterThan(this Argument<int> argument, int someInt) =>
			argument.IsGreaterThan(someInt, "Integer argument '{0}' must be greater than {1}.");

		/// <summary>
		/// Validate that the argument is greater than some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<int> IsGreaterThan(this Argument<int> argument, int someInt, string message)
		{
			if (argument.Value <= someInt)
			{
				throw new ArgumentException(string.Format(message, argument.Name, someInt));
			}
			return argument;
		}


		/// <summary>
		/// Validate that the argument is greater than or equal to some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		[DebuggerStepThrough]
		public static Argument<int> IsGreaterThanOrEqualTo(this Argument<int> argument, int someInt) =>
			argument.IsGreaterThanOrEqualTo(someInt, "Integer argument '{0}' must be greater than or equal to {1}.");

		/// <summary>
		/// Validate that the argument is greater than or equal to some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<int> IsGreaterThanOrEqualTo(this Argument<int> argument, int someInt, string message)
		{
			if (argument.Value < someInt)
			{
				throw new ArgumentException(string.Format(message, argument.Name, someInt));
			}
			return argument;
		}


		/// <summary>
		/// Validate that the argument is less than some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		[DebuggerStepThrough]
		public static Argument<int> IsLessThan(this Argument<int> argument, int someInt) =>
			argument.IsLessThan(someInt, "Integer argument '{0}' must be greater than {1}.");

		/// <summary>
		/// Validate that the argument is less than some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<int> IsLessThan(this Argument<int> argument, int someInt, string message)
		{
			if (argument.Value >= someInt)
			{
				throw new ArgumentException(string.Format(message, argument.Name, someInt));
			}
			return argument;
		}


		/// <summary>
		/// Validate that the argument is less than or equal to some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		[DebuggerStepThrough]
		public static Argument<int> IsLessThanOrEqualTo(this Argument<int> argument, int someInt) =>
			argument.IsLessThanOrEqualTo(someInt, "Integer argument '{0}' must be greater than or equal to {1}.");

		/// <summary>
		/// Validate that the argument is less than or equal to some integer
		/// </summary>
		/// <param name="argument">The string argument to validate</param>
		/// <param name="someInt">The integer to compare to</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<int> IsLessThanOrEqualTo(this Argument<int> argument, int someInt, string message)
		{
			if (argument.Value > someInt)
			{
				throw new ArgumentException(string.Format(message, argument.Name, someInt));
			}
			return argument;
		}
	}
}
