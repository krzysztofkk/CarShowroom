using System;
using System.IO;
using CarShowroom.Database;

namespace CarShowroom.Examples
{
	public static class TestDataset
	{
		//some contact people for brands
		public static Person contact1 = new Person("Harald Neuer", "601-602-603");
		public static Person contact2 = new Person("Stefano Gino", "343-121-777");
		public static Person contact3 = new Person("John Kreuger", "545-300-200");

		//example brands
		public static CarBrand bmw = new CarBrand(1, "BMW", "Germany", contact1);
		public static CarBrand audi = new CarBrand(2, "Audi", "Germany", contact1);
		public static CarBrand ferrari = new CarBrand(3, "Ferrari", "Italy", contact2);
		public static CarBrand ford = new CarBrand(4, "Ford", "USA", contact3);

		//example car models
		public static CarModel bmw_e32 = new CarModel(bmw, "E32", 1992);
		public static CarModel bmw_x5 = new CarModel(bmw, "X5", 2014);
		public static CarModel audi_a8 = new CarModel(audi, "A8", 2011);
		public static CarModel ferr_458 = new CarModel(ferrari, "458", 2013);
		public static CarModel ford_mus = new CarModel(ford, "Mustang GT", 1971);
		public static CarModel ford_foc = new CarModel(ford, "Focus ST", 2015);

		//example cars
		public static Car car1 = new Car(bmw_e32, "A1B22C9123");
		public static Car car2 = new Car(bmw_x5, "G34FG21EF7");
		public static Car car3 = new Car(audi_a8, "HF664RT19V");
		public static Car car4 = new Car(ferr_458, "CV33AC222A");
		public static Car car5 = new Car(ford_mus, "J2K2N55CS4");
		public static Car car6 = new Car(ford_foc, "PP32V15X81");

		//example workers for showrooms
		public static Worker worker1 = new Worker("Tim Smith", "755-125-345", 4500);
		public static Worker worker2 = new Worker("Francois Lupo", "788-787-878", 3750);

		//example clients
		public static Client client1 = new Client("Dave Nowak", "699-911-914");
		public static Client client2 = new Client("George Smith", "450-550-650");

		//example showrooms
		public static Showroom salon1 = new Showroom();
		public static Showroom salon2 = new Showroom();

		public static void Run(bool mode)
		{
			// ### CONSOLE MUTE ###
			var std = Console.Out;
			if (!mode)
				Console.SetOut(TextWriter.Null);
			// ### CONSOLE MUTE ###


			Console.WriteLine("### PERFORMING TEST OPERATIONS ###");
			//fill some data into instances
			client1.AddCar(car6);

			salon1.Authenticate(worker1, "kocham_Milene");
			salon1.AddCar(car1);
			salon1.AddCar(car2);
			salon1.AddCar(car3);
			salon1.AddCar(car4);
			salon1.Clients.Add(client1);

			//client1.CountCars();
			//client1.PrintCars();
			//worker1.CheckInfo();
			//salon1.ListCars();
			//salon1.RemoveCar(car2);
			//salon1.ListCars();
			//salon1.ContactClients();
			Console.WriteLine("### TEST OPERATIONS FINISHED ###\n");

			// ### CONSOLE UNMUTE ###
			if (!mode)
				Console.SetOut(std);
			// ### CONSOLE UNMUTE ###
		}
	}
}