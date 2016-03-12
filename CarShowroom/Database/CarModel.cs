using System;
using System.Runtime.InteropServices;

namespace CarShowroom.Database
{
	public class CarModel
	{
		public CarModel(CarBrand brand, string name, int year)
		{
			Brand = brand;
			Name = name;
			Year = year;
		}

		public CarBrand Brand { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }
	}
}