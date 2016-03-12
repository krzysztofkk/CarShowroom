using System;
using System.Collections.Generic;

namespace CarShowroom.Database
{
	public class Client : Person
	{
		private List<Car> Cars { get; set; }

		public Client(string fullName, string telNumber) : base(fullName, telNumber)
		{
			Cars = new List<Car>();
		}

		public void AddCar(Car car)
		{
			Cars?.Add(car);
			Console.WriteLine("Added {0} {1} from year {2} to {3}'s car list.", car.CarModel.Brand.Name, 
				car.CarModel.Name, car.CarModel.Year, FullName);
		}

		public void CountCars()
		{
			Console.WriteLine("{0} has {1} cars.", FullName, Cars.Count);
		}

		public void PrintCars()
		{
			if (Cars.Count > 0)
			{
				Console.WriteLine("CAR LIST:");
				foreach (var c in Cars)
					Console.WriteLine("{0} {1}, {2}, VIN: {3}", c.CarModel.Brand.Name, c.CarModel.Name, c.CarModel.Year, c.VIN);
			}
			else
			{
				Console.WriteLine("No cars found!");
			}


		}
	}
}