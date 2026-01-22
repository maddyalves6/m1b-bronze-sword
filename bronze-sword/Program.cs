Console.Write("What's your name?: ");
String pName = Console.ReadLine();

Console.Write($"\nWell, {pName}, how much gold've you got?: "); // System.FormatException
int pGold = int.Parse(Console.ReadLine());

Console.WriteLine($"\nA Bronze Sword costs 15 gold. You've got {pGold}.");

Console.Write("y'thinkin' of buyin' it? (y/n):");
String isPurchasing = Console.ReadLine();

if (isPurchasing.ToLower() == "y")
{
    if (pGold >= 15)
    {
        Console.WriteLine($"Look's like you've got enough. Purchasing the sword leaves you with {pGold -= 15}... \nSafe travels, {pName}!");
    }
    else
    {
        Console.WriteLine($"Shame, doesn't look like you've got enough. You're missing {15 - pGold} gold. \nBetter luck next time, {pName}...");
    }
}
else if (isPurchasing.ToLower() == "n")
{
    Console.WriteLine($"Well then, safe travels, {pName}!");
}
else
{
    Console.WriteLine($"Ah. Couldn't quite make that out, and I've actually gotta get on my way. Deals off, {pName}. Safe travels.");
}