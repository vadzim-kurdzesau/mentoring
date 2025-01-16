using System.Collections;

namespace Generics.Demo
{
    internal class GenericsDemo
    {
        public class GenericClass<T> where T : new()
            /*<T, T1, T2, T3>*/
            //where T : class
            //where T1 : struct, IEquatable<T1>
            //where T2: new()
        {
            private readonly T _value;

            public GenericClass(T value)
            {
                _value = value;
            }

            public void Print<TValue>(TValue value) where TValue : struct
            {
                Console.WriteLine(value);
            }
        }

        public static P Method<P>() where P: new()
        {
            return new P();
        }
    }

    #region Repository pattern

    internal interface IIdentifiable
    {
        string Id { get; }
    }

    internal interface IRepository<T> where T : IIdentifiable
    {
        T Get(string id);

        void Add(T entity);
    }

    internal class InMemoryRepository<T> : IRepository<T>,
        IEnumerable<T> where T: IIdentifiable
    {
        private readonly Dictionary<string, T> _entities = new Dictionary<string, T>();

        public void Add(T entity)
        {
            _entities.Add(entity.Id, entity);
        }

        public T Get(string id)
        {
            return _entities[id];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _entities.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    #endregion
}
