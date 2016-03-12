using System;
using CarShowroom.Database;

namespace CarShowroom.Logic
{
	public class AppManager
	{
		public void SellCar(Client client, Showroom showroom, Car car)
		{
			showroom.RemoveCar(car);
			client.AddCar(car);
			Console.WriteLine("Succesfully sold {0} {1} to {2}!", car.CarModel.Brand.Name, car.CarModel.Name, client.FullName);
		}
	}
}