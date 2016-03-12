namespace CarShowroom.Database
{
	public class Person
	{
		public Person(string fullName, int telNumber)
		{
			FullName = fullName;
			TelNumber = telNumber;
		}

		public string FullName { get; }
		public int TelNumber { get; set; }
	}
}