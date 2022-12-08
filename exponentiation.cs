using System.Numerics;

string exit = "";
int number, power;
while (exit != "exit")
{
    try
    {
        Console.WriteLine("please enter the base value.");
        number = Convert.ToInt32(Console.ReadLine());
    }
    catch 
    {
        Console.WriteLine("\nPlease enter a valid number!!!\n");
        continue;
    }

    try
    {
        Console.WriteLine("\nPlease enter the exponent value.");
        power = Convert.ToInt32(Console.ReadLine());
    }
    catch 
    { 
        Console.WriteLine("\nPlease enter a valid number!!!\n");
        continue;
    }
                    
    BigInteger result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }
    Console.WriteLine("\n" + number + " to the power of " + power + " = " + result);

    Console.WriteLine("\nType 'exit' to exit. (press enter to continue.)");
    exit = Console.ReadLine().ToLower();
    Console.Clear();
}
Environment.Exit(0);
