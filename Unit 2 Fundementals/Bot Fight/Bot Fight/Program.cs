int score1 = 0;
int score2 = 0;
int maxAtk1 = 10;
int maxAtk2 = 8;

//fight 
Console.WriteLine("Welcome to the fight arena");


Random r = new Random();
for (int i = 0; i < 3; i++)
{
    int atk1 = r.Next(1, maxAtk1 + 1);
    int atk2 = r.Next(1, maxAtk2 + 1);
    Console.WriteLine($"Bot 1: {atk1}");
    Console.WriteLine($"Bot 2: {atk2}");
    if(atk1 > atk2)
    {
        score1++;
        Console.WriteLine("Bot 1 won that fight");
    }
    else if(atk2 > atk1)
    {
        score2++;
        Console.WriteLine("Bot 2 won that fight");
    }
    else
    {
        Console.WriteLine("Bots tied");
    }
}
Console.WriteLine("FINISHED!");
Console.WriteLine($"Bot 1 score: {score1}");
Console.WriteLine($"Bot 2 score: {score2}");

if(score1 > score2)
{
    Console.WriteLine("Bot 1 won!");
}
else if(score2 > score1)
{
    Console.WriteLine("Bot 2 won!");
}
else
{
    Console.WriteLine("Bots have tied!");
}

