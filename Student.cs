using System;

public class Student
{
    private string name;
    private int age;
    private string grade;

    public void SetName(string studentName)
    {
        name = studentName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int studentAge)
    {
        age = studentAge;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGrade(string studentGrade)
    {
        grade = studentGrade;
    }

    public string GetGrade()
    {
        return grade;
    }

    public static void Main()
    {
        Student student = new Student();

        Console.WriteLine("Enter student name:");
        student.SetName(Console.ReadLine());

        Console.WriteLine("Enter student age:");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid age:");
        }
        student.SetAge(age);

        Console.WriteLine("Enter student grade:");
        student.SetGrade(Console.ReadLine());

        Console.WriteLine("Student Name: " + student.GetName());
        Console.WriteLine("Age: " + student.GetAge());
        Console.WriteLine("Grade: " + student.GetGrade());
    }
}
