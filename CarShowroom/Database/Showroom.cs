using System;
using System.Collections.Generic;

namespace CarShowroom.Database
{
	public class Showroom
	{
		public List<Worker> Workers;
		public List<Client> Clients;
		public List<Car> Cars = new List<Car>();
		public DateTime LastModified;

		public void AddCar(Car car)
		{
			LastModified = DateTime.Now;
			Cars.Add(car);
		}

		public void RemoveCar(Car car)
		{
			LastModified = DateTime.Now;
			Cars.Remove(car);
		}

		public void ListCars()
		{
			int n = 0;
			foreach (Car c in Cars)
			{
				Console.WriteLine("Last modification: {0}", LastModified);
				n++;
				Console.WriteLine("No. #{0}: {1} {2} from {3}", n, c.CarModel.Brand.Name, c.CarModel.Name, c.CarModel.Year);
			}
		}

	}
}