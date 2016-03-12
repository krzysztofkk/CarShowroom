using System;
using CarShowroom.Database;
using CarShowroom.Logic;

namespace CarShowroom
{
	internal class Program
	{
		private static void Main()
		{
			var contact1 = new Person("John Neuer", "601-602-603");
			var contact2 = new Person("Stefano Gino", "343-121-777");

			var bmw = new CarBrand(1, "BMW", "Germany", contact1);
			var audi = new CarBrand(2, "Audi", "Germany", contact1);
			var ferrari = new CarBrand(3, "Ferrari", "Italy", contact2);

			var model1 = new CarModel(bmw, "E32", 1992);
			var model2 = new CarModel(audi, "A8", 2011);
			var model3 = new CarModel(ferrari, "458", 2013);

			var car1 = new Car(model1, "A1B22C9123");
			var car2 = new Car(model2, "G34FG21EF7");
			var car3 = new Car(model3, "HF664RT19V");

			Console.WriteLine("\n");

			var client1 = new Client("Dave Nowak", "699-911-914");
			client1.AddCar(car2);
			client1.AddCar(car3);

			client1.CountCars();
			client1.PrintCars();

			Console.WriteLine("\n");

			var worker1 = new Worker("Tim Smith", "755-125-345", 4500);
			worker1.CheckInfo();

			Console.WriteLine("\n");

			var salon1 = new Showroom();
			salon1.AddCar(car1);
			salon1.AddCar(car2);
			salon1.AddCar(car3);
			salon1.ListCars();

			Console.WriteLine("\n");

			salon1.RemoveCar(car2);
			salon1.ListCars();

			Console.WriteLine("\n");

			salon1.Clients.Add(client1);
			salon1.ContactClients();

			Console.WriteLine("\n");
			var manager = new AppManager();
			manager.SellCar(client1, salon1, car1);

			//idle
			Console.ReadKey();
		}
	}
}
