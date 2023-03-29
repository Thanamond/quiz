using System;

public class Program
{
    static int InputCompetitor(int n)
    {
        if(1< n <= 10000)
        {
            return int.Parse(Console.ReadLine());;
        }
    }

    static int InputSelected(int k)
    {
        if(1 <= k <= 1000)
        {
            return int.Parse(Console.ReadLine());
        }
    }

    static int SexOfCompetitor(int a)
    {
        return int.Parse(Console.ReadLine());
    }

    static int FirstScore(int b)
    {
        return int.Parse(Console.ReadLine());
    }

    static int SecondScore(int c)
    {
        return int.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        InputCompetitor(n);
        InputSelected(k);
        
        for (int i = 1; i <= n;i++)
        {
            SexOfCompetitor(a);
            FirstScore(b);
            SecondScore(c);
            for (int i = 1; i <= k; i++)
            {
                if(b > c && a == 1)
                {
                    Console.WriteLine("{0} {1}",i,1);
                }
                if(b < c && a == 2)
                {
                    Console.WriteLine("{0} {1}",i,2);
                }
                if(b == 9 || b==10 || c==9 || c==10)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("{0} {1}",i,1);
                    }
                    if (a == 2)
                    {
                        Console.WriteLine("{0} {1}",i,2);
                    }
                }    
            }
        }


    }




}