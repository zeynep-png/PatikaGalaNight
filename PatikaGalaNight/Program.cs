
List<string> visitors = new List<string>();

que: Console.WriteLine("Davetli girebilirsiniz: ");
visitors.Add(Console.ReadLine());
Console.WriteLine("Başka davetli eklemek ister misiniz? (e/h)");
string c = Console.ReadLine();

if (c == "e")
    goto que;

Console.WriteLine("\n----DAVETLİ LİSTESİ----\n");
for (int i = 0; i < visitors.Count; i++)
{
    Console.WriteLine((i+1) + "- " +visitors[i]); // List indexim 0dan başladığı için +1 yazarak listeyi yazdırdım
}