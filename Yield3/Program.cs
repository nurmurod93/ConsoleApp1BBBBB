using System.Collections.Generic;

class Program
{
    static void Main()
    {
        foreach (var number in GenericNumbers(1, 10, 3))
        {
            Console.WriteLine(number);
        }
    }
    static IEnumerable<int> GenericNumbers(int start, int end, int step)
    {
        for(int i = start; i <= end; i += step) 
        {
            yield return i;
        }
    }
}