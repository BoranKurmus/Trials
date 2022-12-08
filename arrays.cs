using System.Diagnostics.CodeAnalysis;


//Creating a random array.

int[] numbers = new int[10];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
    numbers[i] = random.Next(1, 200);


//Finding the number of numbers that more than 100.

int counter = 0;

foreach (int i in numbers)
    if (i > 100)
        counter++;
Console.WriteLine("the number of numbers that bigger than 100 in the list is: " + counter);


//Finding the average of numbers less than 150.

counter = 0;
int sum = 0;
int avrg;

foreach (int i in numbers)
    if (i < 150)
    {
        counter++;
        sum += i;
    }
avrg = sum / counter;
Console.WriteLine("\nThe average of numbers less than 150 in the list is: " + avrg);


//Finding the number of even numbers.

counter = 0;
foreach (int i in numbers)
    if (i % 2 == 0)
        counter++;
Console.WriteLine("\nThe number of even numbers in the list is: " + counter);


//Let's see the list for check the answers.

Console.WriteLine("\nAn array of 10 randomly generated numbers between 1 and 200 is as shown below.");
foreach (int i in numbers)
    Console.WriteLine(i);
