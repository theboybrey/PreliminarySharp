using System;

public class Employee
{
    private string name;
    private string designation;
    private decimal salary;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Designation
    {
        get { return designation; }
        set { designation = value; }
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public static void Main()
    {
        Employee emp = new Employee();

        Console.WriteLine("Enter employee name:");
        emp.Name = Console.ReadLine();

        Console.WriteLine("Enter employee designation:");
        emp.Designation = Console.ReadLine();

        Console.WriteLine("Enter employee salary:");
        decimal salary;
        while (!decimal.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine("Invalid input. Please enter a valid salary:");
        }
        emp.Salary = salary;

        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Designation: " + emp.Designation);
        Console.WriteLine("Salary: GHS" + emp.Salary);
    }
}
