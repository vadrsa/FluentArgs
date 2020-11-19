using System.Diagnostics;

namespace Microsoft.Extensions.Args
{
	/// <summary>
	/// Extension methods for <see cref="FluentArgs.Argument{T}"/>
	/// </summary>
	public static class ArgumentExtensions
	{
		/// <summary>
		/// Wrap your argument in a way that lets FluentArgs work with it
		/// </summary>
		/// <typeparam name="T">Type of your argument</typeparam>
		/// <param name="value">Value of the argument</param>
		/// <param name="name">Name of the argument</param>
		/// <returns>A wrapped FluentArgs argument</returns>
		[DebuggerStepThrough]
		public static Argument<T> Arg<T>(this T value, string name) => 
			new Argument<T>(value, name);

		/// <summary>
		/// Wrap your argument in a way that lets FluentArgs work with it
		/// </summary>
		/// <typeparam name="T">Type of your argument</typeparam>
		/// <param name="value">Value of the argument</param>
		/// <param name="name">Name of the argument</param>
		/// <returns>A wrapped FluentArgs argument</returns>
		[DebuggerStepThrough]
		public static Argument<T> Arg<T>(this object value, string name) => 
			new Argument<T>((T)value, name);
	}
}
