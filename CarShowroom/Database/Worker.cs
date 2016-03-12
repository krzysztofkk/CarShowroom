using System;

namespace CarShowroom.Database
{
	public class Worker : Person
	{
		public int Salary { get; private set; }

		private string _position;
		public string Position
		{
			get { return _position ?? "empty"; }
			private set { _position = value; }
		}

		public Worker(string fullName, string phoneNumber, int salary) : base(fullName, phoneNumber)
		{
			Salary = salary;
		}
		public void IncreaseSalary(int amount)
		{
			Salary += amount;
		}

		public void ChangePosition(string position)
		{
			Position = position;
		}

		public void CheckInfo()
		{
			Console.WriteLine("\tSTAFF MEMBER INFO");
			Console.WriteLine("\tFull name: {0}", base.FullName);
			Console.WriteLine("\tJob: {0}", Position);
			Console.WriteLine("\tSalary: {0}", Salary);
		}
	}
}