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
        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();

        Console.Write("Введите фамилию: ");
        string lastName = Console.ReadLine();

        Console.Write("Введите возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Person person = new Person(firstName, lastName, age);
        person.PrintInfo();
    }
}
