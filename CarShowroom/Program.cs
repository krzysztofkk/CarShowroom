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
			//FALSE - silent, TRUE - log output
			TestDataset.Run(true);

			//instance of ShowroomManager shall be passed to UI, which would require some sort of authentication
			var manager = new ShowroomManager();
			manager.SellCar(TestDataset.client1, TestDataset.salon1, 3);




			Console.ReadKey();
		}
	}
}
