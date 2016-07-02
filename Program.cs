using System;

namespace ConsoleApplication {
	public class Program {
		public static void Main(string[] args) {
			Console.WriteLine("main test start");
			ServerInitializer.Init();
			Console.WriteLine("main test end");
		}
	}
}