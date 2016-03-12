namespace CarShowroom.Database
{
	public class CarBrand
	{
		public CarBrand(int id, string name, string country, Person contact)
		{
			Id = id;
			Name = name;
			Country = country;
			Contact = contact;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Country { get; set; }
		public Person Contact { get; set; }
	}
}