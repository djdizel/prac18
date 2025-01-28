using System;

class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int House { get; set; }
    public int Apartment { get; set; }

    public Address(string index, string country, string city, string street, int house, int apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }

    public void PrintAddress()
    {
        Console.WriteLine($"Индекс: {Index}");
        Console.WriteLine($"Страна: {Country}");
        Console.WriteLine($"Город: {City}");
        Console.WriteLine($"Улица: {Street}");
        Console.WriteLine($"Дом: {House}");
        Console.WriteLine($"Квартира: {Apartment}");
    }
}

class Program
{
    static void Main()
    {
        Address myAddress = new Address("123456", "Россия", "Москва", "Тверская", 10, 25);
        myAddress.PrintAddress();
    }
}