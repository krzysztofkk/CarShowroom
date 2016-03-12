using System;
using CarShowroom.Database;

namespace CarShowroom.Logic
{
	public class ShowroomManager
	{
		public void ListCars(Showroom showroom)
		{
			foreach (var c in showroom.Cars)
				Console.WriteLine("ID: {0} - {1} {2}, {3}, VIN: {4}", c.Id, c.CarModel.Name, c.CarModel.Brand.Name, c.CarModel.Year, c.VIN);
		}
		public Car FindCar(int id, Showroom showroom)
		{
			return showroom.Cars.Find(x => x.Id == id);
		}

		public void SellCar(Client client, Showroom showroom, int id)
		{
			var car = showroom.Cars.Find(x => x.Id == id);
			if (car != null)
			{
				showroom.Cars.Remove(car);
				client.AddCar(car);
				Console.WriteLine("Succesfully sold {0} {1} to {2}!", car.CarModel.Brand.Name, car.CarModel.Name, client.FullName);
			}
			else
			{
				Console.WriteLine("Car with such ID could not have been found.");
			}

		}


	}
}