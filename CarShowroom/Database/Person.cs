namespace CarShowroom.Database
{
	public class Person
	{

		public string FullName { get; set; }
		public int TelNumber { get; set; }

		public Person(string fullName, int telNumber)
		{
			FullName = fullName;
			TelNumber = telNumber;
		}
	}
}