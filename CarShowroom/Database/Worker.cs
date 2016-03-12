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

		public Worker(string fullName, string telNumber, int salary) : base(fullName, telNumber)
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
			Console.WriteLine("Full name: {0}", base.FullName);
			Console.WriteLine("Job: {0}", Position);
			Console.WriteLine("Salary: {0}", Salary);
		}
	}
}