using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1BBBBB
{
    public class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;

        public WeekEnumerator(string[] days) => this.days = days;

        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new ArgumentException();
                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;           
        }

        public void Reset() => position = -1;
        public void Dispose() { }
    }
    class Week
    {
        string[] days = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };
        
        public IEnumerator GetEnumerator() => new WeekEnumerator(days);
    }
}
