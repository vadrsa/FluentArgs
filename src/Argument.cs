namespace FluentArgs
{
	public class Argument {
		public static void Inline(params Argument[] arguments) { }
	}
	
	/// <summary>
	/// Represents an argument to validate
	/// </summary>
	/// <typeparam name="T">Type of the argument</typeparam>
	public class Argument<T> : Argument
	{
		private readonly T _value;
		private readonly string _name;

		public Argument(T value, string name)
		{
			this._value = value;
			this._name = name;
		}

		public T Value => _value;
		public string Name => _name;

	}
}
