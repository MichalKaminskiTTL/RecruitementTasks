using System;
					
public class Program
{
	public static void Main()
	{
		Person personOverride = new PersonOverride();
		Person personNew = new PersonNew();
		
		personOverride.WhoAmI();
		personNew.WhoAmI();
	}
	
	public class Person
	{
		public virtual void WhoAmI()
		{
			Console.WriteLine("I'm Person");
		}
	}
	
	public class PersonOverride : Person
	{
		public override void WhoAmI()
		{
			Console.WriteLine("I'm Override");
		}
	}
	
	public class PersonNew : Person
	{
		public new void WhoAmI()
		{
			Console.WriteLine("I'm New");
		}
	}
}