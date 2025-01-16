using System.Collections;

namespace Iterators.Demo
{
    public class Collection
    {
        public static IEnumerable<string> GetText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException();
            }

            return GetTextImpl();
        }

        private static IEnumerable<string> GetTextImpl()
        {
            yield return "Hello";
            yield return "How are you doing?";
            yield return "Bye";
        }
    }

    public class ReversedArrayIterator<T> : IEnumerable<T>
    {
        private readonly T[] _array;

        public ReversedArrayIterator(T[] array)
        {
            _array = array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ReversedEnumerator(_array);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class ReversedEnumerator : IEnumerator<T>
        {
            private readonly T[] _values;
            private int _index;

            public ReversedEnumerator(T[] values)
            {
                _values = values;
                _index = _values.Length;
            }

            public T Current
            {
                get
                {
                    if (_index == _values.Length)
                    {
                        throw new InvalidOperationException("Enumeration has not started. Call MoveNext.");
                    }

                    return _values[_index];
                }
            }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_index <= 0)
                {
                    return false;
                }

                _index--;
                return true;
            }

            public void Reset()
            {
                _index = _values.Length;
            }

            public void Dispose()
            {
                // Do nothing
            }
        }
    }
}
