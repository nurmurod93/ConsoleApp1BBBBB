namespace IdexerInCSharp
{
    public struct Program
    {
        public static void Main(string[] args) 
        {
            //var xodim1 = new Xodim(1, "Ali", "vali", "10.01.1998", "Erkak", "Ozbek", "+998715684295", "hellosalom@gmail.com", 29000);
            //var xodim2 = new Xodim(2, "Kim", "Jin", "12.30.1997", "Erkak", "Xitoy", "+998715465645","almisoxdanqolgan@gmail.com", 5000);
            //var xodim3 = new Xodim(3, "Li", "Jin", "10.25.1996", "Erkak", "Taivan", "+998975869568", "videolibrary@gmail.ru", 6000);
            //var xodim4 = new Xodim(4, "Son", "Li", "14.11.1994", "Erkak", "Korea", "+998974862486", "alibaba@gmail.com", 7891);

            //var xodimlar = new List<Xodim>() { xodim1, xodim2, xodim3, xodim4 };
            //xodimlar.PrintAllConsole();

            var genericxodim1 = new GenericXodim<string>();
            genericxodim1[0] = "5";
            genericxodim1[1] = "Alesher";
            genericxodim1[2] = "Lutfulloyev";
            genericxodim1[3] = "01.01.1996";
            genericxodim1[4] = "Erkak";
            genericxodim1[5] = "Xitoy";
            genericxodim1[6] = "+998975864895";
            genericxodim1[7] = "alibaba@gmail.com";
            genericxodim1[8] = "20000";

            var genericxodim2 = new GenericXodim<string>();
            genericxodim2[0] = "6";
            genericxodim2[1] = "Song";
            genericxodim2[2] = "Li";
            genericxodim2[3] = "01.01.1995";
            genericxodim2[4] = "Erkak";
            genericxodim2[5] = "Korea";
            genericxodim2[6] = "+998975885895";
            genericxodim2[7] = "alibabali@gmail.com";
            genericxodim2[8] = "60000";

            var genericxodim3 = new GenericXodim<string>();
            genericxodim3[0] = "7";
            genericxodim3[1] = "Li";
            genericxodim3[2] = "Li";
            genericxodim3[3] = "01.01.1999";
            genericxodim3[4] = "Erkak";
            genericxodim3[5] = "Taivar";
            genericxodim3[6] = "+998975864695";
            genericxodim3[7] = "alibabaakasi@gmail.com";
            genericxodim3[8] = "80000";

            var genericxodim4 = new GenericXodim<string>();
            genericxodim4[0] = "8";
            genericxodim4[1] = "Kim";
            genericxodim4[2] = "Li";
            genericxodim4[3] = "01.01.1996";
            genericxodim4[4] = "Erkak";
            genericxodim4[5] = "Filippin";
            genericxodim4[6] = "+998975864895";
            genericxodim4[7] = "alibabaukasi@gmail.com";
            genericxodim4[8] = "30000";

            var genericXodimlar = new List<GenericXodim<string>>() { genericxodim1, genericxodim2, genericxodim3, genericxodim4 };
            genericXodimlar.PrintAllGenericConsole();

            //Console.WriteLine();


            //var indekser = new IndexerHosilQilish();
            //indekser[0] = 80;
            //indekser[1] = 70;
            //indekser[2] = 60;
            //indekser[3] = 50;

            //Console.WriteLine("Idexser qiymatlari:");

            //for(int i = 0; i<4;  i++) 
            //{
            //    Console.WriteLine("Indexsator[{0}] = {1}", i, indekser[i]);
            //}
        }
    }
}