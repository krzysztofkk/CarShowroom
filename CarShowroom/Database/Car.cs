namespace CarShowroom.Database
{
	public class Car
	{
		public CarModel CarModel { get; set; }
		public string VIN { get; set; }

		public Car(CarModel model, string vin)
		{
			CarModel = model;
			VIN = vin;
		}
	}
}