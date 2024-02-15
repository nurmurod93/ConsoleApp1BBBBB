namespace MyGenericCllectionT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] GenericMassiv = { 3, 5, 7, 9, 0, 22, 1, 34, 54 };
            //MyGenericCollection<int> intKolleksiya = new MyGenericCollection<int>(GenericMassiv);

            //foreach (int element in intKolleksiya)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine();

            string[] mevaArray = { "olma", "olcha", "anor", "gilos" };
            MyGenericCollection<string> mevalarKolleksiya = new MyGenericCollection<string>(mevaArray);

            foreach(string element in mevalarKolleksiya) 
            {
                Console.WriteLine(element);
            }
        }
    }
}