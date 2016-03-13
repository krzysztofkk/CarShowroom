using System;
using System.Collections.Generic;

namespace CarShowroom.Database
{
	public class Client : Person
	{
		public List<Car> OwnedCars = new List<Car>();

		public Client(string fullName, string phoneNumber) : base(fullName, phoneNumber)
		{
		}

		public void AddCar(Car car)
		{
			OwnedCars.Add(car);
			Console.WriteLine("Added {0} {1} from year {2} to {3}'s car list.", car.CarModel.Brand.Name, 
				car.CarModel.Name, car.CarModel.Year, FullName);
		}

		public void CountCars()
		{
			Console.WriteLine("{0} has {1} cars.", FullName, OwnedCars.Count);
		}

		public void PrintCars()
		{
			Console.WriteLine("{0}'s CAR LIST:", FullName);
			if (OwnedCars.Count > 0)
			{
				foreach (var c in OwnedCars)
					Console.WriteLine("{0} {1}, {2}, VIN: {3}", c.CarModel.Brand.Name, c.CarModel.Name, c.CarModel.Year, c.VIN);
			}
			else
			{
				Console.WriteLine("No cars found!");
			}


		}
	}
}