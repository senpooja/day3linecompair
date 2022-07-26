
using System;

class GFG
{

    // Function to check if they are identical
    static void compair(double a1, double b1,
                         double a2, double b2)
    {
        if ((a1 / a2 == b1 / b2))
            Console.WriteLine("The given straight"
            + " lines are identical");

        else
            Console.WriteLine("The given straight"
                + " lines are not identical");
    }

    // Driver Code
    public static void Main(String[] args)
    {
        double a1 = -2, b1 = 4,
                a2 = -6, b2 = 12;
        compair(a1, b1, a2, b2);
    }
}

// This code contributed by Rajput-Ji