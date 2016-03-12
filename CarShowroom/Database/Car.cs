namespace CarShowroom.Database
{
	public class Car
	{
		private static int _numberOfCars = 0;
		public int Id { get; private set; }
		public CarModel CarModel { get; set; }
		public string VIN { get; set; }

		public Car(CarModel model, string vin)
		{
			CarModel = model;
			VIN = vin;
			Id = ++_numberOfCars;
		}
	}
}