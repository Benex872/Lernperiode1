Console.WriteLine("===== True or False Quiz=====");
int punkte = 0;

Console.WriteLine("Sind sie ein Mensch true/false? ");
bool antwort1= Convert.ToBoolean(Console.ReadLine());
if (antwort1 == true)
{
    Console.WriteLine("Das ist Richtig!!");
    punkte++;
}
else
{
    Console.WriteLine("Das ist Falsch!!");
}

Console.WriteLine("Sind sie ein Tier true/false? ");
bool antwort2= Convert.ToBoolean(Console.ReadLine());
if (antwort2 == true)
{
    Console.WriteLine("Das ist Richtig!!");
    punkte++;
}
else
{
    Console.WriteLine("Das ist Falsch!!");
}
Console.WriteLine("Sind sie ein Roboter true/false? ");
bool antwort3= Convert.ToBoolean(Console.ReadLine());
if (antwort3 == true)
{
    Console.WriteLine("Das ist Richtig!!");
    punkte++;
}
else
{
    Console.WriteLine("Das ist Falsch!!");

}
Console.WriteLine("Sie haben " + punkte + "  ereicht!! ");