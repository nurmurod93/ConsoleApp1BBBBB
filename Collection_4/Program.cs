using System.IO;

//StreamWriter bloknot = new StreamWriter("D:/sonlat.txt");

//for (int i = 0; i < 10; i++)

//    bloknot.WriteLine(i);

//bloknot.Close();
//Console.WriteLine("sonlar bloknotga yozildi");

//StreamReader sonlartxt = new StreamReader("D:/sonlar.txt");

//string matn = sonlartxt.ReadToEnd();
//Console.WriteLine(matn);

//Console.ReadKey();

StreamWriter writer = new StreamWriter("biror.txt");
writer.WriteLine("Salom, Dunyo !!!");
writer.Close();

byte[] bytesAll = File.ReadAllBytes("biror.txt");

MemoryStream memoryStream = new MemoryStream(bytesAll);

StreamReader stream = new StreamReader(memoryStream);

string line;
while ((line = stream.ReadLine()) != null)
    Console.WriteLine(line);
stream.Close();

memoryStream.Close();

