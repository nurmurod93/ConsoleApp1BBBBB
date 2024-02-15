using System.Collections.Generic;
using System.Dynamic;

class Program
{
    static void Main()
    {
        foreach(int number in GetNumbers())
        {
            Console.WriteLine(number);
        }
    }
    static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
}