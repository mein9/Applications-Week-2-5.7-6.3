using System;

namespace ApplicationsWeek2;

public class Program
{
    public static void Main(string[] args)
    {
        string test = "string";
        Console.WriteLine(First(test)); //should print s
        Console.WriteLine(Rest(test)); // should print tring
        Console.WriteLine(Length(test)); // should print 6
        WriteString(test); // should print string with one char on each line
        WriteBackward(test); // should print gnirts with one char on each line
        ReverseString(test); // should print gnirts on the same line
        Console.WriteLine(SquareRoot((double) 9)); // should print 3ish
    }

    // first: returns the first character of the given string
    public static char First(string s)
    {
        return s[0];
    }

    // rest: returns a new string that contains all but the
    // first letter of the given string
    public static string Rest(string s)
    {
        return s.Substring(1);
    }

    // length: returns the length of the given string
    public static int Length(string s)
    {
        return s.Length;
    }
    public static void WriteString(string s)
    {
        foreach (char c in s)
        {
            Console.WriteLine(c);
        }
    }
    public static void WriteBackward(string s) 
    {
        int length = s.Length ;
        for (int i = length - 1; i >= 0; i--)
        {
            Console.WriteLine(s[i]);
        }
    }
    public static string ReverseString(string s)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            reversed.Append(s[i]);
        }
        return reversed.ToString();
        }
    }
    public static double SquareRoot(double root)
    {
        
        double squareRoot =  root / 2;

        while (true)
        {
            double nextSquareRoot = (squareRoot + root / squareRoot) / 2;

            if (Math.Abs(squareRoot - nextSquareRoot) < 0.0001) //repeats until within acceptable range of square root
                break;

            squareRoot = nextSquareRoot; // sets the loop up with the closest number so far
        }
        return squareRoot;
    }
}
