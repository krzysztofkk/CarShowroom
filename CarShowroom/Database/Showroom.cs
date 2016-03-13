using System;
using System.Collections.Generic;

namespace CarShowroom.Database
{
	public class Showroom
	{
		private List<Worker> Workers = new List<Worker>();
		private List<Client> Clients = new List<Client>();
		private List<Car> AvailableCars = new List<Car>();
		private Worker ActiveWorker = new Worker("unknown", "unknown", 0);
		private const string PassCode = "kocham_Milene";
		public bool Authenticated;
		public DateTime LastModified;

		public void Authenticate(Worker worker, string passcode)
		{
			if (passcode == PassCode)
			{
				ActiveWorker = worker;
				Authenticated = true;
				Console.WriteLine("Authentication succesfull.");
			}
			else
			{
				Console.WriteLine("Authentication failed - wrong passcode.");
			}
		}

		public Car FindCar(int carId)
		{
			return AvailableCars.Find(x => x.Id == carId);
		}

		public void AddCar(Car car)
		{
			LastModified = DateTime.Now;
			AvailableCars.Add(car);
			Console.WriteLine("Added {0} {1} to showroom. ({2})", car.CarModel.Brand.Name, car.CarModel.Name, ActiveWorker.FullName);
		}

		public void RemoveCar(Car car)
		{
			LastModified = DateTime.Now;
			AvailableCars.Remove(car);
			Console.WriteLine("Removed {0} {1} from showroom. ({2})", car.CarModel.Brand.Name, car.CarModel.Name, ActiveWorker.FullName);
		}

		public void ListCars()
		{
			int n = 0;
			Console.WriteLine("Last modification: {0} by {1}", LastModified, ActiveWorker.FullName);
			foreach (var c in AvailableCars)
			{
				n++;
				Console.WriteLine("{5}. ID: {0} - {1} {2}, {3}, VIN: {4}", c.Id, c.CarModel.Name, c.CarModel.Brand.Name, c.CarModel.Year, c.VIN, n);
			}
		}

		public void ContactClients()
		{
			foreach(Client c in Clients)
				Console.WriteLine("{0} {1}", c.FullName, c.PhoneNumber);
		}

		public void AddClient(Client client)
		{
			Clients.Add(client);
			Console.WriteLine("Added {0} to client list. ({1})", client.FullName, ActiveWorker.FullName);
		}
	}
}