using System;

public class Car
{
    private string make;
    private string model;
    private int year;

    public string Make
    {
        get { return make; }
        set { make = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    public static void Main()
    {
        Car car = new Car();

        Console.WriteLine("Enter the manufactuere of the car:");
        car.Make = Console.ReadLine();

        Console.WriteLine("Enter the model of the car:");
        car.Model = Console.ReadLine();

        Console.WriteLine("Enter car year:");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.WriteLine("Invalid input. Please enter a valid year:");
        }
        car.Year = year;

        Console.WriteLine("Car Manufacturer: " + car.Make);
        Console.WriteLine("Car Model: " + car.Model);
        Console.WriteLine("Car Year: " + car.Year);
    }
}
