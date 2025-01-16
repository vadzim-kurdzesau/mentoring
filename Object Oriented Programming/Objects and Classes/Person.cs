// namespace MyProgram;

using System.Diagnostics.CodeAnalysis;
using System.Text;

class Fighter
{
    public int strength;
    public int speed;

    public Fighter()
    {
    }

    public Fighter(int strength, int speed)
    {
        this.strength = strength;
        this.speed = speed;
    }

    public void Kick()
    {
        Console.WriteLine("Kia");
    }
}

namespace ConsoleApp
{
    class Smartphone
    {
        public string Brand = "Unknown";
        public string Color = "Black";

        public Smartphone()
        {
            Console.WriteLine("Smartphone inited");
        }

        public Smartphone(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        public void Call(string to)
        {
            Console.WriteLine($"Smartphone call to {to}");
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            var smartphone = new Smartphone(brand: "Redmi Note 9s", color: "Black");
            smartphone.Call("Mike");
        }
    }
}

public static class Utils
{
    public static int GetMaxValue(this int[] numbers, int number)
    {
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (result < numbers[i])
            {
                result = numbers[i];
            }
        }

        return result;
    }
}

public readonly struct Point
{
    public readonly int x;
    public readonly int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }


}

public class Square // static = abstract sealed
{
    // Backing field
    private readonly int length = 0;
    public static int number;

    public const int Digit = 1;
    public static readonly Person person = new Person("Hello");

    static Square()
    {
        Console.WriteLine("Static ctor was called");
    }

    public Square(int length)
    {
        this.length = length;
    }

    public static void Call()
    {
        Console.WriteLine("Static method was called");
    }

    public int Length { get; set; }

    public int Area
    {
        get
        {
            return Length * Length;
        }
    }

    public void SetLength(int length)
    {
        Length = length;
    }

    public int GetArea()
    {
        return Length * Length;
    }
}

public class Person
{
    private string name;
    private string _name;

    // Property
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            name = value;
        }
    }

    // Fields
    public string Surname;

    public int Age;

    public Person Friend;

    public Person(string name)
    {
        Name = name;
        Console.WriteLine("One parameter called");
    }

    public Person(string name, string surname) : this(name, surname, 18, null)
    {
        Console.WriteLine("Two parameters called");
    }

    public Person(string name, string surname, int age, Person person)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Friend = person;
    }

    public void PrintName()
    {
        Console.WriteLine(Name);
    }
}