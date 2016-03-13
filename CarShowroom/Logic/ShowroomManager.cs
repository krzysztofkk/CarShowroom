using System;
using CarShowroom.Database;

namespace CarShowroom.Logic
{
	public class ShowroomManager
	{
		public void ListCars(Showroom showroom)
		{
			Console.WriteLine("[Trying to ListCars]");
			foreach (var c in showroom.AvailableCars)
				Console.WriteLine("ID: {0} - {1} {2}, {3}, VIN: {4}", c.Id, c.CarModel.Name, c.CarModel.Brand.Name, c.CarModel.Year, c.VIN);
		}
		public Car FindCar(int id, Showroom showroom)
		{
			Console.WriteLine("[Trying to FindCar]");
			return showroom.AvailableCars.Find(x => x.Id == id);
		}

		public void SellCar(Client client, Showroom showroom, int id)
		{
			Console.WriteLine("[Trying to SellCar]");
			var car = showroom.AvailableCars.Find(x => x.Id == id);
			if (car != null && showroom.Authenticated)
			{
				showroom.AvailableCars.Remove(car);
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




	}
}