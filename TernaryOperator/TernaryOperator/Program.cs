﻿namespace TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 10;
            var result = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(result);
            Console.WriteLine(result.GetType().ToString());
        }
    }
}