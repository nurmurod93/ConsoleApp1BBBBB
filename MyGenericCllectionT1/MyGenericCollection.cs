using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericCllectionT1
{
    public class MyGenericCollection<T> : IEnumerable<T>
    {
        private T[] elements;

        public MyGenericCollection(T[] array)
        {
            elements = array;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyGenericEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class MyGenericEnumerator: IEnumerator<T> 
        {
            private MyGenericCollection<T> collection;
            private int currentIndex;

            public MyGenericEnumerator(MyGenericCollection<T> coll) 
            {
                collection = coll;
                currentIndex = -1;
            }
            public bool MoveNext() 
            {
                currentIndex++;
                return (currentIndex < collection.elements.Length);
            }
            public void Reset() 
            {
                currentIndex = -1;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public T Current
            {
                get
                {
                    if (currentIndex >= 0 && currentIndex < collection.elements.Length)
                    {
                        return collection.elements[currentIndex];
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
            object IEnumerator.Current => Current;
        }
    }
}
