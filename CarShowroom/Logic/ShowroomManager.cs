using System;
using CarShowroom.Database;

namespace CarShowroom.Logic
{
	public class ShowroomManager
	{
		private const string Ver = "0.1";

		public void Greet()
		{
			Console.WriteLine("\t\tShowroom Management Tool (v{0})\n", Ver);
		}

		public void ListCars(Showroom showroom)
		{
			Console.WriteLine("[Trying to ListCars]");
			showroom.ListCars();
		}

		public Car FindCar(Showroom showroom, int carId)
		{
			Console.WriteLine("[Trying to FindCar]");
			return showroom.FindCar(carId);
		}

		public void SellCar(Showroom showroom, Client client, int id)
		{
			Console.WriteLine("[Trying to SellCar]");
			var car = showroom.FindCar(id);
			if (car != null && showroom.Authenticated)
			{
				showroom.RemoveCar(car);
				client.AddCar(car);
				Console.WriteLine("Succesfully sold {0} {1} to {2}!\n", car.CarModel.Brand.Name, car.CarModel.Name, client.FullName);
			}
			else
			{
				var err1 = "";
				var err2 = "";
				if (car == null && !showroom.Authenticated)
				{
					err1 = "\nCar with such ID could not have been found.";
					err2 = "\nYou are not authenticated.";
				}
				else if (car != null & !showroom.Authenticated)
					err2 = "\nYou are not authenticated.";
				else if (car == null && showroom.Authenticated)
					err1 = "\nCar with such ID could not have been found.";

				Console.WriteLine("Error! Operation failed.{0}{1}\n", err1, err2);
			}
		}

		public void AddCar(Showroom showroom, Car car)
		{
			Console.WriteLine("[Trying to AddCar]");
			showroom.AddCar(car);
			Console.WriteLine("Succesfully added {0} {1} to the showroom!\n", car.CarModel.Brand.Name, car.CarModel.Name);
		}
	}
}