namespace IEnumurable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MeningMassivim = { 1, 2, 3, 4, 5 };
            MYCollection mYCollection = new MYCollection(MeningMassivim);

            foreach (int element in mYCollection)
            {
                Console.WriteLine(element);
            }
        }
    }
}