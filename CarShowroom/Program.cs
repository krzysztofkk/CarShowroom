using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShowroom.Database;

namespace CarShowroom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var person1 = new Person("John Kowalski", 2005050);
			var brand1 = new CarBrand(1, "BMW", "Germany", person1);
			var brand2 = new CarBrand(2, "Audi", "Germany", person1);
			var model1 = new CarModel(brand1, "E32", 1992);

			var car1 = new Car(model1, "A1B22C9123");
			var car2 = new Car(model1, "G34FG21EF7");

			Console.WriteLine(brand1.Name);
			Console.WriteLine(person1.FullName);

			Console.WriteLine("\n");

			var client1 = new Client("Dave Nowak", 500200);
			client1.AddCar(car1);
			client1.AddCar(car2);

			client1.CountCars();

			client1.PrintCars();

			Console.ReadKey();
		}
	}
}
