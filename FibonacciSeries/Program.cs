using System;
 class Program
{
    static void Main()
    {
        string strUserChoice = string.Empty;
        do
        {
            Console.WriteLine("Enter the count for fibonacci series:");
            bool isNum = int.TryParse(Console.ReadLine(), out int result);
            if (isNum)
            {
                FibonacciSeries(result);
                RecursiveFibonacciSeries(result);
                int N=getNthFibonacciNumber(result);
                Console.WriteLine("The {0}th term in the Fibonacci series is {1}", result, N);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            do
            {
                Console.WriteLine("Do you want to continue? YES or NO");
                strUserChoice = Console.ReadLine().ToUpper();
            } while (strUserChoice != "YES" && strUserChoice != "NO");
        } while (strUserChoice == "YES");
        Console.Write("Press any key to exit");
        Console.ReadKey();
    }
    private static void FibonacciSeries(int length)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        Console.WriteLine("Fibonacci Series is");
        Console.WriteLine("{0}\n{1}", a, b);
        for(int i=1;i<length;i++)
        {
            c = a + b;
            Console.Write("{0}\n", c);
            a = b;
            b = c;
        }
    }
    public static void RecursiveFibonacciSeries(int length)
    {
        Console.WriteLine("Recursive fibonacci series Begins:");
        Recursive(0, 1, 1, length);
        Console.WriteLine("Recursive fibonacci series Ends:");
    }
    private static void Recursive(int a,int b,int counter,int len)
    {
        
       if(counter <=len)
        {
            Console.Write("{0}\n", a);
            Recursive(b, a + b, counter + 1, len);
        }
     
    }
    private static int getNthFibonacciNumber(int N)
    {
        //since count start at 0;
        int number = N - 1;
        int[] Fib = new int[number + 1];
        Fib[0] = 0;
        Fib[1] = 1;
        for (int i = 2; i <= number; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }
        return Fib[number];
    }

}
