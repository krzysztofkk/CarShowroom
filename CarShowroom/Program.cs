using System;
using CarShowroom.Examples;
using CarShowroom.Logic;

namespace CarShowroom
{
	internal class Program
	{
		private static void Main()
		{
			//prepare some example data to work with, a basic database mock
			TestDataset.Run();

			var manager = new ShowroomManager();
			manager.SellCar(TestDataset.client1, TestDataset.salon1, 3);

			//idle
			Console.ReadKey();
		}
	}
}
