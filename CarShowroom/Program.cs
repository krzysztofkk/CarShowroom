using System;
using CarShowroom.Examples;
using CarShowroom.Logic;

namespace CarShowroom
{
	internal class Program
	{
		private static void Main()
		{
			//Console.ForegroundColor = ConsoleColor.Yellow;

			//prepare some example data to work with, a basic database mock
			//FALSE - silent, TRUE - log output
			TestDataset.Run(false);

			//instance of ShowroomManager shall be passed to UI, which would require some sort of authentication
			var manager = new ShowroomManager();
			manager.Greet();
			TestDataset.salon1.Authenticated = false;
			manager.SellCar(TestDataset.salon1, TestDataset.client1, 2);
			TestDataset.salon1.Authenticated = true;
			manager.SellCar(TestDataset.salon1, TestDataset.client1, 2);
			manager.SellCar(TestDataset.salon1, TestDataset.client1, 5);

			manager.AddCar(TestDataset.salon1, TestDataset.car5);

			manager.ListCars(TestDataset.salon1);




			Console.ReadKey();
		}
	}
}
