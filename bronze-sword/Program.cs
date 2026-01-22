// ask playername and store
Console.Write("What's your name?: ");
String pName = Console.ReadLine();

// ask for gold
Console.Write($"\nWell, {pName}, how much gold've you got?: "); // System.FormatException

// take input and try until player gives a parseable int as their gold.
bool validGold = false;
int pGold = 0;
while (!validGold)
{
    try
    {
        pGold = int.Parse(Console.ReadLine());
        validGold = true;
    }
    catch (System.FormatException)
    {
        Console.Write("I ain't even sure that's a real number, how much gold've you got really?: ");
        validGold = false;
    }
}

// describe price of sword
Console.WriteLine($"\nA Bronze Sword costs 15 gold. You've got {pGold}.");

// prompt player to buy sword
Console.Write("y'thinkin' of buyin' it? (y/n): ");
String isPurchasing = Console.ReadLine();

// buy sword if yes, explain missing gold if no, leave if invalid
if (isPurchasing.ToLower() == "y")
{
    if (pGold >= 15)
    {
        Console.WriteLine($"\nLook's like you've got enough. Purchasing the sword leaves you with {pGold -= 15}... \nSafe travels, {pName}!");
    }
    else
    {
        Console.WriteLine($"\nShame, doesn't look like you've got enough. You're missing {15 - pGold} gold. \nBetter luck next time, {pName}...");
    }
}
else if (isPurchasing.ToLower() == "n")
{
    Console.WriteLine($"\nWell then, safe travels, {pName}!");
}
else
{
    Console.WriteLine($"\nAh. Couldn't quite make that out, and I've actually gotta get on my way. Deal's off, {pName}. Safe travels.");
}