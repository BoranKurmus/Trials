using System.Numerics;

int number;
string exit = "";
while (exit != "exit")
{
    try
    {
        Console.WriteLine("Please enter the number whose factorial is to be calculated.");
        number = Convert.ToInt32(Console.ReadLine());

    }
    catch
    {
        Console.WriteLine("Please enter a valid number!!!");
        continue;
    }

    BigInteger result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    Console.WriteLine("\n" + number + "!" + " = " + result);

    Console.WriteLine("\nType 'exit' to exit. (press enter to continue.)");
    exit = Console.ReadLine().ToLower();
    Console.Clear();
}
Environment.Exit(0);
