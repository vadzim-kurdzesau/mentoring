namespace Interfaces.Demo.Examples
{
    public interface IPet
    {
        void Speak();
    }

    public interface ISpeakable
    {
        void Speak();
    }

    public class Cat : IPet
    {
        public void Speak()
        {
            Console.WriteLine("Cat says meow!");
        }

        public void Sleep()
        {
        }
    }

    public class Dog : IPet
    {
        public void Speak()
        {
            Console.WriteLine("Dog says woof!");
        }
    }

    public static class PetsExample
    {
        public static void Demonstrate()
        {
            IPet[] animals = new IPet[]
            {
                new Dog(),
                new Cat(),
                new Dog(),
                new Dog(),
                new Cat(),
            };

            foreach (var animal in animals)
            {
                animal.Speak();
            }
        }
    }
}
