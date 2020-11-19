using System;
using System.Diagnostics;

namespace Microsoft.Extensions.Args
{
	/// <summary>
	/// Extension methods for generic <see cref="Argument{T}"/>
	/// </summary>
	public static class GenericArgumentExtensions
	{
		/// <summary>
		/// Validate that the argument is not null
		/// </summary>
		/// <typeparam name="T">Type of the argument</typeparam>
		/// <param name="argument">Argument to validate</param>
		[DebuggerStepThrough]
		public static Argument<T> IsNotNull<T>(this Argument<T> argument) => 
			argument.IsNotNull("Argument {0} cannot be null.");

		/// <summary>
		/// Validate that the argument is not null
		/// </summary>
		/// <typeparam name="T">Type of the argument</typeparam>
		/// <param name="argument">Argument to validate</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<T> IsNotNull<T>(this Argument<T> argument, string message)
		{
			if (argument.Value == null)
			{
				throw new ArgumentNullException(string.Format(message, argument.Name));
			}
			return argument;
		}


		/// <summary>
		/// Validate that the argument passes the predicate test
		/// </summary>
		/// <typeparam name="T">Type of the argument</typeparam>
		/// <param name="argument">Argument to validate</param>
		[DebuggerStepThrough]
		public static Argument<T> Is<T>(this Argument<T> argument, Func<T, bool> predicate) => 
			argument.Is(predicate, "Argument {0} is invalid.");

		/// <summary>
		/// Validate that the argument passes the predicate test
		/// </summary>
		/// <typeparam name="T">Type of the argument</typeparam>
		/// <param name="argument">Argument to validate</param>
		/// <param name="message">Exception message template</param>
		[DebuggerStepThrough]
		public static Argument<T> Is<T>(this Argument<T> argument, Func<T, bool> predicate, string message)
		{
			if (!predicate(argument.Value))
			{
				throw new ArgumentException(string.Format(message, argument.Name));
			}
			return argument;
		}
	}
}
