namespace Generics.Demo
{
    internal class CovarianceDemo
    {
        private class Animal
        {
        }

        private class Cat : Animal
        {
        }

        public static void DemonstrateBasics()
        {
            Animal animal = new Animal();
            AcceptCovariant(animal);

            Cat cat = new Cat();
            AcceptCovariant(cat);

            AcceptContravariant(cat);
            // AcceptContravariant(animal);

            // Can assign class with MORE derived parameter type to interface with it's BASE type
            ICovariantCollection<Animal> animals = new CovariantCollection<Cat>();
            //ICovariantCollection<Cat> catAnimals = new CovariantCollection<Animal>();

            // Can assign class with LESS derived parameter type to interface with MORE derived type
            IContravariantCollection<Cat> cats = new ContravariantCollection<Animal>();
            //IContravariantCollection<Animal> animalCats = new ContravariantCollection<Cat>();
        }

        private static void AcceptCovariant(Animal animal)
        {
            Console.WriteLine($"Animal of type \"{animal.GetType()}\" has been accepted.");
        }

        private static void AcceptContravariant(Cat cat)
        {
            Console.WriteLine($"Contravariant cat of type \"{cat.GetType()}\" has been accepted.");
        }
    }

    #region Covariance

    internal interface ICovariantCollection<out T>
    {
        T GetValue(int index);

        //void Add(T item);
    }

    internal class CovariantCollection<T> : ICovariantCollection<T>
    {
        public T GetValue(int index)
        {
            // Some logic here
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Contravariance

    internal interface IContravariantCollection<in T>
    {
        //T GetValue(int index);

        void Add(T item);
    }

    internal class ContravariantCollection<T> : IContravariantCollection<T>
    {
        public void Add(T item)
        {
            // Some logic here
            throw new NotImplementedException();
        }
    }

    #endregion

    // Good example why covariance and contravariance can be applied only to interfaces, but not the whole classes
    internal class ContraCovariantCollection<T> : ICovariantCollection<T>, IContravariantCollection<T>
    {
        private readonly List<T> _values = new List<T>();

        public void Add(T item)
        {
            _values.Add(item);
        }

        public T GetValue(int index)
        {
            return _values[index];
        }
    }
}
