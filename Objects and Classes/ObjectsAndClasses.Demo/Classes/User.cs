using System;

namespace ObjectsAndClasses.Demo.Classes;

public class User
{
    #region Class state

    public string firstName;
    public string lastName;

    #endregion

    #region Class behaviour

    // Methods
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {firstName} {lastName}.");
    }

    #endregion
}
