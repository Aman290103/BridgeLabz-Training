using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        double principal = 1000;
        double rate = 5;
        double time = 2;

        double si = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest = " + si);
    }
}
