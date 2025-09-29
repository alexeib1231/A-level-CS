using System;
using System.Numerics;

Console.WriteLine("Enter the number of natural numbers");
BigInteger n = BigInteger.Parse(Console.ReadLine());
Console.WriteLine((n/2) * (1 + n)); 