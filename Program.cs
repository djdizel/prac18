using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Возраст: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Иван", "Иванов", 30);
        
        person.PrintInfo();
    }
}
