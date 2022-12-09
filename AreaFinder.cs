class Methods
{    
    static void Main()
    {       
        while(true)
        {
            Console.Clear();
            //Choice.

            Console.WriteLine("\nPlease choose square, rectangle, circle or triangle (s/r/c/t)");
            string choice = Console.ReadLine();

            //Square.
            if (choice == "s")
            {
                Console.WriteLine("Enter the measure of one side of the square");
                int side = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe area of the square is: " + areaSqr(side));
                Console.WriteLine("\nPress 'enter' to continue or press 'ctrl+c' to exit.");
                Console.ReadLine();
            }

            //Rectangle.
            else if (choice == "r")
            {
                Console.WriteLine("\nEnter the measure of short side of the rectangle");
                int side1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter the measure of long side of the rectangle");
                int side2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe area of the rectangle is: " + arearctg(side1, side2));
                Console.WriteLine("\nPress 'enter' to continue or press 'ctrl+c' to exit.");
                Console.ReadLine();
            }

            //Circle.
            else if (choice == "c")
            {
                Console.WriteLine("\nPlease enter the radius of the circle.");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe area of the circle is: " + areacrc(r));
                Console.WriteLine("\nPress 'enter' to continue or press 'ctrl+c' to exit.");
                Console.ReadLine();
            }

            //Triangle.
            else if (choice == "t")
            {
                Console.WriteLine("\nPlease enter the height of the triangle.");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPlease enter the baseline of the triangle.");
                int baseline = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThe area of the circle is: " + areatrg(baseline, height));
                Console.WriteLine("\nPress 'enter' to continue or press 'ctrl+c' to exit.");
                Console.ReadLine();
            }
        }
        
    }

    // Method/Function that finds the area of a square.
    static int areaSqr(int side)
    {
        int area = side * side;
        return area;         
    }

    // Method/Function that finds the area of a rectangle.
    static int arearctg(int side1, int side2)
    {
        int area = side1 * side2;
        return area;
    }

    // Method/Function that finds the area of a circle.
    static double areacrc(int r)
    {
        double area = 3.14 * r * r;
        return area;
    }

    // Method/Function that finds the area of a triangle.
    static double areatrg(double baseline, double height)
    {
        double area = (height * baseline) / 2;
        return area;
    }
}
