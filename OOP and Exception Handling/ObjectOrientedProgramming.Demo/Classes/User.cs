using System;

namespace ObjectOrientedProgramming.Demo.Classes;

public class User
{
    private string firstName;

    public User(string firstName)
        : this(firstName, null)
    {
    }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName 
    {
        get => firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            firstName = value;
        }
    }

    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            if (LastName == null)
            {
                return FirstName;
            }

            return $"{FirstName} {LastName}";
        }
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, my name is {FullName}.");
    }
}
