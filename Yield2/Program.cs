using System.Collections.Generic;

class Program
{
    static void Main()
    {
        foreach(int Chiquvchilar in RaqamlarniAylantiradi(10))
        {
            Console.WriteLine(Chiquvchilar);
        }
    }
    static IEnumerable<int> RaqamlarniAylantiradi(int count)
    {
        for(int i=1; i<=count; i++)
        {
            if(i%2==0)
            {
                yield return i;
            }
        }
    }
}