//string proekt = "Mening do'stim";
//int Besh = 5;
//Besh = 6;
//Console.WriteLine($"{proekt}, {Besh}");

//string stringVar = "salom dunyo";
//int intVar = 100;
//float floatVar = 10.2f;
//char chrVar = 'A';
//bool  boolVar = true;

//byte b1 = 255;
////byte b2 = -128;
//sbyte sb1 = -128;
//sbyte sb2 = 127;

//Console.WriteLine(Byte.MaxValue);
//Console.WriteLine(Byte.MinValue);
//Console.WriteLine(SByte.MaxValue);
//Console.WriteLine(SByte.MinValue);

//int i = - 2147483648;
//int j = 2147483647;
////int k = 4294967295;

//uint  u = 4294967295;
////uint mu = - 1;

//Console.WriteLine(Int32.MaxValue);
//Console.WriteLine(Int32.MinValue);
//Console.WriteLine(UInt32.MaxValue);
//Console.WriteLine(UInt32.MinValue);

//int hex = 0x2F;

//int binary = 0b_0010_1111;

//Console.WriteLine(hex);
//Console.WriteLine(binary);


//long l1 = -9223372036854775808;
//long l2 = 9223372036854775807;

//ulong ul1 = 18223372036854775808ul;
//ulong ul2 = 18223372036854775808UL;

//Console.WriteLine(Int64.MaxValue);
//Console.WriteLine(Int64.MinValue);
//Console.WriteLine(UInt64.MaxValue);
//Console.WriteLine(UInt64.MinValue);

//float f1 = 123456.5F;
//float f2 = 1.123456f;

//Console.WriteLine(f1);
//Console.WriteLine(f2);

//double d1 = 12345678912345.5d;
//double d2 = 1.123456789123456D;

//Console.WriteLine(d1);
//Console.WriteLine(d2);

//decimal @decimal1 = 123456789123456789123456789.5m;
//decimal @decimal2 = 1.1234567891345679123456789123m;

//Console.WriteLine(@decimal1);
//Console.WriteLine(@decimal2);

//int javob;
//int qiymat1 = 10, qiymat2 = 11;
//javob = qiymat2 - qiymat1;
//Console.WriteLine( "Arifmetik operator: \n" + javob);
//Console.WriteLine( $"Arifmetik operator: \n{ qiymat1 + qiymat2}");

//int x = 5, y = 8, result;

//result = x > y ? x : y;

//Console.WriteLine("Mantiqiy operator Javob: " +  result);


//int qiymatbool = 5, qiymatbool2 = 8, natija;

//natija = qiymatbool < qiymatbool2 ? qiymatbool : qiymatbool2;

//Console.WriteLine("Mantiqiy operator Javob: " + natija);

//int kun = 2;
//switch(kun)
//{
//    case 1:
//    Console.WriteLine("Dushanba");
//    break;

//    case 2:
//    Console.WriteLine("Seshanba");
//    break;

//    default: 
//    Console.WriteLine("Bu kun emas!");
//    break;
//}

//string  Ism;

//Console.WriteLine("ismingizni kiriting");

//Ism = Console.ReadLine();

//Console.WriteLine($"Mening ismim: {Ism}");

//string Nom;
//int Yosh;
//Console.WriteLine("Nomi va Yoshi yozilsin");
//Nom = Console.ReadLine();
//Yosh = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Nomi: {Nom} Yoshi: {Yosh}");

//int a, b;
//Console.WriteLine("a qiymat kirit: ");
//Console.WriteLine("b qiymat kirit: ");
//a = Convert.ToInt32(Console.ReadLine());
//b = int.Parse(Console.ReadLine());
//Console.WriteLine("Natija: " + (a+b));

//---------------------------------------------------------------------------------------------------

// IF ELSE

//---------------------------------------------------------------------------------------------------


//int menMilliyarder;
//Console.WriteLine("Pullaring qancha? ");
//menMilliyarder = int.Parse(Console.ReadLine());
//if (menMilliyarder > 999999999)
//{
//    Console.WriteLine($"Siz rostdanham Milliyarder! {menMilliyarder}$");
//}
//else
//{
//    Console.WriteLine("Hali yetmading");
//}

//-------------------------------------------------------------------------------------------------
//SWITCH CASE
//-------------------------------------------------------------------------------------------------

//int ozgaruvchi;
//ozgaruvchi = Convert.ToInt32(Console.ReadLine());

//switch (ozgaruvchi)
//{
//    case 6:
//        Console.WriteLine("o'nga");
//        break;
//    case 4: Console.WriteLine("Chapga");
//        break;
//    case 8: Console.WriteLine("Yuqoriga");
//        break;
//    case 2: Console.WriteLine("Pastga");
//        break;
//    default: Console.WriteLine("Bonaqa komanda yo'q");
//        break;
//}

//------------------------------------------------------------------------------------------------

// Math Sinfi

//-----------------------------------------------------------------------------------------------

//Console.WriteLine("Burchakni radianda kiriying: ");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Sinus: " + Math.Sin(a));
//Console.WriteLine("Kosinus: " + Math.Cos(a));

//Console.ReadKey();

//Console.Write("a=");
//double b = double.Parse(Console.ReadLine());
//double c = Math.Pow(Math.Floor(Math.Acos(Math.Abs(a) / (Math.Abs(a) + 1))), Math.PI) + Math.Exp(Math.Sin(Math.Log(Math.Log(a), 2)));
//Console.WriteLine("Javob: " + b);
//Console.ReadKey();

//-----------------------------------------------------------------------------------------------

//FOR,  WHILE, DO WHILE SIKL OPERATORLARI

//-----------------------------------------------------------------------------------------------

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i + "\t");
//}

//int j = 1;
//while (j < 10)
//{
//    Console.WriteLine("G'ani g'ildirakni  vizillatib g'izillatdi");
//    j++;
//}

//while(true)
//{
//    Console.WriteLine("G'ani g'ildirakni  vizillatib g'izillatdi");
//}

//int k  = 0;
//do
//{
//    Console.WriteLine("G'ani g'ildirakni  vizillatib g'izillatdi");
//    k++;
//}
//while (k >= 33);

//int num;
//int nextdigit;
//Console.Write("Son: ");
//num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Sonning raqamlari teskari tartibda:");

//do
//{
//    nextdigit = num % 10;
//    Console.Write(nextdigit);
//    num = num / 10;
//}
//while (num > 0);
//Console.WriteLine();


//int[] qiymatlar = new int[5] { 5, 6, 7, 8, 9 };

//foreach (var item in qiymatlar)
//{
//    Console.WriteLine("HA Bale! " + item);
//}

//Console.WriteLine();
//Console.WriteLine();

//string[] mevalar = { "olma", "anor", "uzum", "O'rik", "do'lana" };
//foreach (var item in mevalar)

//{
//    Console.WriteLine(item);
//}

//----------------------------------------------------------------------------------------------------
// BREAK, CONTINUE, GOTO KALIT SO'ZLAR
//---------------------------------------------------------------------------------------------------

//int hakamSana =0;
//while(true)
//{
//    hakamSana++;
//    Console.WriteLine(hakamSana);
//    if(hakamSana == 10 )
//    { 
//        break; 
//    }
//}

//int hakam = 0;
//while (true)
//{
//    int secund = 0;
//    while (true)
//    {
//        secund++;
//        if (secund > 3 * 60)
//        {
//            Console.WriteLine("Rount Tugadi!");
//            break;
//        }
//    }
//}
//Console.WriteLine("TUGADI");



//string engzorbokschi = "Bohodir Jalolov";
//switch(engzorbokschi)
//{
//    case "Bill Geyts":
//        Console.WriteLine("Bill Geyts Milliarder");
//        break;
//    case "Bohodir Jalolov":
//        Console.WriteLine("Bohodir Jalolov");
//        break;
//    case "Mayk Tayson":
//        Console.WriteLine("Mayk Tayson");
//        break;
//    case "Shaxram G'iyosov":
//        Console.WriteLine("Shaxram G'iyosov");
//        break;
//    default:
//        Console.WriteLine("////////");
//        break;
//}

//for(int i=0; i<10; i++)
//{
//    if (i % 2 == 0)
//        continue;
//    else
//        Console.WriteLine(i);
//}

//for (int i=0; i<10;i++)
//{
//    if (i == 8)
//        continue;
//    else
//    {
//        Console.WriteLine(i+ " ");
//    }
//}


//bool active = false;
//string say = "salom";

//kalit:

//if(active)
//{
//    Console.WriteLine(say);
//}
//if(active == false)
//{
//    active = true;
//    goto kalit;
//}
//Console.ReadKey();

//int n = 0;
//if(n == 0)
//{
//    while(true)
//    {
//        if(n == 10)
//        {
//            goto kaliti;
//        }
//        n += 2;
//    }
//}
//Console.WriteLine("Asosiy");
//while(true)
//{
//    Console.WriteLine("Salom");
//}
//kaliti:
//Console.WriteLine("\nQalaysiz");


//using System.Collections;



//using System.Collections;

//namespace arrylist
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            ArrayList dasturlash = new ArrayList();

//            List<string> list = new List<string>();

//            list.Add("iz");
//            list.Add("go");
//            list.Add("hi");
//            dasturlash.Add("c");
//            dasturlash.Add(2);
//            dasturlash.Add("d");
//            dasturlash.Add(3.45);
//            dasturlash.AddRange(list);
            
//            dasturlash.Remove("c");
//            dasturlash.RemoveAt(2);
//            dasturlash.RemoveRange(0, 2);
//            //dasturlash.Clear();
//            dasturlash.Sort();
//            foreach (var dastur in dasturlash)
//            {
//                Console.WriteLine(dastur);
//            }
//        }
//    }
//}

//using System.Collections;

//var Ustozlar = new List<string>{"Muhammadkarim", "Temur", "Zohidbek" };
//LinkedList<string> Ustoz = new LinkedList<string>(Ustozlar);
//Console.WriteLine(Ustoz.Count);
//Console.WriteLine(Ustoz.First.Value);
//Console.WriteLine(Ustoz.Last.Value);

//var people =new LinkedList<string>();
//people.AddLast("Abror");
//people.AddFirst("Muhammadamin");

//if(people.First != null)
//    people.AddAfter(people.First, "Hasan");
//foreach(var person in people)
//    Console.WriteLine(person);


//SortedList list_nomi = new SortedList() { { 1, "Vali" }, { 2, "Guli"}, {3,"Charli" }, {4, "Chori" } };

//SortedList list_nomi2 = new SortedList();

//list_nomi2.Add(1, "Zari");
//list_nomi2.Add(2, "Zaxro");
//list_nomi2.Add(3, "Zarifa");

//string x = (string)list_nomi2[2];
//Console.WriteLine(x);

////for(int i = 0; i < list_nomi.Count; i++)
////{
////    Console.WriteLine($"{list_nomi.GetKey(i)} - {list_nomi.GetByIndex(i)}");
////}

//foreach(DictionaryEntry pair in list_nomi2)
//{
//    Console.WriteLine($"{pair.Key} - {pair.Value}");
//}

//SortedList Mashinalar = new SortedList();

//Mashinalar.Add(1, "Lamborgihine");
//Mashinalar.Add(2, "Mersedes");
//Mashinalar.Add(3, "BMW");
//Mashinalar.Add(4, "RollsRoys");
//Mashinalar.Add(5, "Bentley");
//Mashinalar.Add(6, "Tesla");
//Mashinalar.Add(7, "Marussa");
//Mashinalar.Add(8, "Mazda");

////Mashinalar.Clear(); // xammasini o'chiradi
////Mashinalar.Remove(2); //belgilanganini o'chiradi
////Mashinalar.RemoveAt(3);// belgilangandan keyigisini o'chiradi

//Console.WriteLine(Mashinalar.Contains(3)); //natija consolga true chiqaradi element borligini tasdiqlaydi
//Console.WriteLine(Mashinalar.ContainsKey(6)); //natija consolga true chiqaradi element borligini tasdiqlaydi
//Console.WriteLine(Mashinalar.ContainsValue("Marussa")); //natija consolga true chiqaradi element borligini tasdiqlaydi

////foreach(DictionaryEntry pair in Mashinalar)
////{
////    Console.WriteLine($"{pair.Key}-{pair.Value}");
////}

//Dictionary<string, string> Mdic = new Dictionary<string, string>();
//Mdic.Add("1", ".net");
//Mdic.Add("2", "C#");
//Mdic.Add("3", "Asp.Net");
//Mdic.Add("4", "LINQ");
//Mdic.Add("5", "PHP");
//Mdic.Add("6", "html");

//Console.WriteLine($"juftliklar soni : {Mdic.Count}");

////Console.WriteLine("Clear_____");
////Mdic.Clear();

//foreach (var item in Mdic)
//{
//    Console.WriteLine($"Kalit = {item.Key} Qiymat = {item.Value}");

//}
//    Console.WriteLine("*******************************************");

//    Mdic.Remove("1"); //kalit 1 ga teng bo'lgan juftliklarni o'chiribtashlaydi

//    Mdic.Remove("2"); //kalit 2 ga teng bo'lgan juftliklarni o'chiribtashlaydi

//Console.WriteLine($"juftliklar soni : {Mdic.Count}");

//foreach (var item in Mdic)
//{
//    Console.WriteLine($"Kalit = {item.Key} Qiymat = {item.Value}");
//}



//Dictionary<string, string>.KeyCollection KColl = Mdic.Keys;
//foreach(var item in KColl)
//{
//    Console.WriteLine($"kalit - {item}");
//}

//Dictionary<string, string>.ValueCollection VColl = Mdic.Values;

//foreach(var item in VColl)
//{
//    Console.WriteLine($"qiymati - {item}");
//}


//***********************************************************************************************************//


//Hashtable hesh = new Hashtable();
//hesh.Add(1, "1");
//hesh.Add(2, "2");
//hesh.Add(3, "3");


//foreach (DictionaryEntry t in hesh)
//{
//    Console.WriteLine($"kalit: {t.Key} - qiymat{t.Value}");
//}

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//


using System.Collections;

//string[] people = { "Tom", "Sam", "Bob" };

//IEnumerator peopleEnumurator = people.GetEnumerator();

//while (peopleEnumurator.MoveNext())
//{
//    string item = (string)peopleEnumurator.Current;
//    Console.WriteLine(item);
//}
//peopleEnumurator.Reset();

 
//Week week = new Week();
//foreach (var day in week)
//{
//Console.WriteLine(day);
//}

//public class WeekEnumerator : IEnumerator
//{
//    string[] days;
//    int position = -1;

//    public WeekEnumerator(string[] days) => this.days = days;

//    public object Current
//    {
//        get
//        {
//            if (position == -1 || position >= days.Length)
//                throw new ArgumentException();
//            return days[position];
//        }
//    }

//    public bool MoveNext()
//    {
//        if (position < days.Length - 1)
//        {
//            position++;
//            return true;
//        }
//        else
//            return false;
//    }

//    public void Reset() => position = -1;
//    public void Dispose() { }
//}
//class Week
//{
//    string[] days = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };

//    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
//}




