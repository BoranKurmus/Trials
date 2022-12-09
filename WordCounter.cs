class WordCounter
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of pharagraphs.");
        int pnum = Convert.ToInt32(Console.ReadLine());
        int index = 1;
        int total = 0;
        while (index <= pnum)
        {
            Console.WriteLine("Please enter the " + index + "." + " paragraph.");
            string paragraph = Console.ReadLine();
            Console.WriteLine("\nThe number of words in this paraghraph is: " + counter(paragraph));
            total += counter(paragraph);
            index++;
        }

        Console.WriteLine("\nThe total number of words is: " + total); 
    }
    
    static int counter(string sentence)
    {
        int counter = 1;
        foreach (char letter in sentence)
        {
            if (letter == ' ')
                counter++;
        }
        return counter;
    }
}
