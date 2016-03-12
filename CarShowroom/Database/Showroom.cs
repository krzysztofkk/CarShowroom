using System;
using System.Collections.Generic;

namespace CarShowroom.Database
{
	public class Showroom
	{
		public List<Worker> Workers = new List<Worker>();
		public List<Client> Clients = new List<Client>();
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
			Console.WriteLine("Removed {0} {1} from showroom.", car.CarModel.Brand.Name, car.CarModel.Name);
		}

		public void ListCars()
		{
			int n = 0;
			Console.WriteLine("Last modification: {0}", LastModified);
			foreach (Car c in Cars)
			{
				n++;
				Console.WriteLine("No. #{0}: {1} {2} from {3}", n, c.CarModel.Brand.Name, c.CarModel.Name, c.CarModel.Year);
			}
		}

		public void ContactClients()
		{
			foreach(Client c in Clients)
				Console.WriteLine("{0} {1}", c.FullName, c.TelNumber);
		}

	}
}