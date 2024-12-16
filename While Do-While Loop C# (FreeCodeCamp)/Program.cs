// See https://aka.ms/new-console-template for more information
Console.WriteLine("While Do-While Loop");

//  Do While

//Random rnd = new Random();

//int current = 0;

//do
//{
//    current = rnd.Next(0,10);
//    if (current > 8) continue;

//    Console.WriteLine(current);
//}
//while (current != 7);



////  While 

//while (current > 3)
//{
//    current = rnd.Next(0, 15);
//    Console.WriteLine("While====>>>>>"+current);
//}


//      Monster And Hero Game Challenge While And Do While Loop

int hero = 10;
int monster = 10;

Random random = new Random();

do
{
    int roll = random.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and its health is {monster}");

    if (monster <= 0) continue;

    roll = random.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and its health is {hero}");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero Wins!" : "Mnster Wins!");





Console.ReadKey();