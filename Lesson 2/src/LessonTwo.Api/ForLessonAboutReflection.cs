using System;
using System.Reflection;

Type myType = typeof(Person);
Person tom = new Person("Tom", 31);

var ageProp = myType.GetProperty("Age");
int[] agePerson = { 51, 22, 43, 34, 27 };
for (int i = 0; i < 5; i++)
{
	ageProp?.SetValue(tom, agePerson[i]);
	tom.Print();
}


public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}
	public void Print() => Console.WriteLine($"{Name} - {Age}");
}
