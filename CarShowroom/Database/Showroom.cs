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
		public Worker ActiveWorker = new Worker("unknown", "unknown", 0);
		private const string PassCode = "kocham_Milene";

		public void Authenticate(Worker worker, string passcode)
		{
			if (passcode == PassCode)
			{
				ActiveWorker = worker;
				Console.WriteLine("Authentication succesfull.");
			}
			else
			{
				Console.WriteLine("Authentication failed - wrong passcode.");
			}
		}

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
			Console.WriteLine("Last modification: {0} by {1}", LastModified, ActiveWorker.FullName);
			foreach (var c in Cars)
			{
				n++;
				Console.WriteLine("{0}. ID: [{4}] - {1} {2} from {3}", n, c.CarModel.Brand.Name, c.CarModel.Name, c.CarModel.Year, c.Id);
			}
		}

		public void ContactClients()
		{
			foreach(Client c in Clients)
				Console.WriteLine("{0} {1}", c.FullName, c.PhoneNumber);
		}

	}
}