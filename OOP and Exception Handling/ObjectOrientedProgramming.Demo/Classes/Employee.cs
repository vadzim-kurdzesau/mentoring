using System;

namespace ObjectOrientedProgramming.Demo.Classes;

public class Employee : User
{
    private string companyName;

    public Employee(string firstName)
        : base(firstName)
    {
    }

    public Employee(string firstName, string lastName)
        : base(firstName, lastName)
    {
    }

    public string CompanyName
    {
        get => companyName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            companyName = value;
        }
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hello, my name is {FullName}. I work in \"{CompanyName}\".");
    }
}
