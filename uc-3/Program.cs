
using System;

class GFG
{

    // Function to check if they are identical
    static void idstrt(double a1, double b1,
                         double a2, double b2)
    {
        if ((a1 / a2 == b1 / b2))
            Console.WriteLine("The given straight"
            + " lines are identical");

        else if ((a1 / a2 < b1 / b2))

            Console.WriteLine("first line a is greter than b ");

        else


            Console.WriteLine("first line is less than b ");
    }

    // Driver Code
    public static void Main(String[] args)
    {
        double a1 = -2, b1 = 4,
                a2 = -6, b2 = 25;
        idstrt(a1, b1, a2, b2);
    }
}

// This code contributed by Rajput-Ji