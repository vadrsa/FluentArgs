using System;

namespace FluentArgsConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				new Test(" ", 1);
			}
			catch(Exception e)
			{

			}
		}
	}
}
