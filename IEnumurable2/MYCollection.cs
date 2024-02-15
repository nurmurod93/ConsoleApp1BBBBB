using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumurable2
{
    public class MYCollection : IEnumerable
    {
        private int[] element;

        public MYCollection(int[] array)
        {
            element = array;
        }
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }
        private class MyEnumerator : IEnumerator
        {
            private MYCollection collection;
            private int currentIndex;
            public MyEnumerator(MYCollection coll)
            {
                collection = coll;
                currentIndex = -1;
            }
            public bool MoveNext() 
            {
                currentIndex++;
                return (currentIndex < collection.element.Length);
            }
            public void Reset() 
            {
                currentIndex = -1;
            }
            public object Current
            {
                get
                {
                    if(currentIndex >= 0 && currentIndex < collection.element.Length)
                    {
                        return collection.element[currentIndex];
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }
}
