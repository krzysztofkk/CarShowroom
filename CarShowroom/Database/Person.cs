namespace CarShowroom.Database
{
	public class Person
	{

		public string FullName { get; set; }
		public string TelNumber { get; set; }

		public Person(string fullName, string telNumber)
		{
			FullName = fullName;
			TelNumber = telNumber;
		}
	}
}