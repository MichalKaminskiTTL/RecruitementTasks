using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Service.GenericCall(new List<string>());
		Service.GenericCall(new List<Person>());
	}
	
	public static class Service
    {
        public static void Call(IEnumerable<object> objectsList)
        {
            Console.WriteLine("I'm IEnumerable one.");
        }

        public static void Call(params object[] objectsList)
        {
            Console.WriteLine("I'm params one.");
        }

        public static void GenericCall<T>(IEnumerable<T> genericList)
        {
            Call(genericList);
        }
    }
	
	public class Person {}
}