// A Hello World From Ha Le program in C#.
using System;

namespace HelloWorld
{
	class Hello
	{
		static void Main()
		{
			String TheGreeting = "Hello World";
			String MyName = "Ha Le";

			Console.WriteLine($"{TheGreeting} From  {MyName}");
			//Kep the console window open in debug mode.

			Console.ReadKey();
		}
	}
}
