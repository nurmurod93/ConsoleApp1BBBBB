using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInterface
{
    public class Customer : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
