using System;
using CarShowroom.Database;

namespace CarShowroom
{
	internal class Program
	{
		private static void Main()
		{
			var person1 = new Person("John Kowalski", 2005050);

			var brand1 = new CarBrand(1, "BMW", "Germany", person1);
			var brand2 = new CarBrand(2, "Audi", "Germany", person1);

			var model1 = new CarModel(brand1, "E32", 1992);
			var model2 = new CarModel(brand2, "A8", 2011);

			var car1 = new Car(model1, "A1B22C9123");
			var car2 = new Car(model1, "G34FG21EF7");
			var car3 = new Car(model2, "HF664RT19V");

			Console.WriteLine(brand1.Name);
			Console.WriteLine(person1.FullName);

			Console.WriteLine("\n");

			var client1 = new Client("Dave Nowak", 500200);
			client1.AddCar(car1);
			client1.AddCar(car2);
			client1.AddCar(car3);

			client1.CountCars();
			client1.PrintCars();

			Console.WriteLine("\n");

			var worker1 = new Worker("Tim Smith", 203050, 4500);
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

			//idle
			Console.ReadKey();
		}
	}
}
