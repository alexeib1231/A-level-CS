
using System.Diagnostics;
using System.Runtime.InteropServices;

static void EqualOrNot() {
    Console.WriteLine("Enter your first integer:");
    int int1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your second integer:");
    int int2 = Convert.ToInt32(Console.ReadLine());

    if (int1 == int2)
    {
        Console.WriteLine("The integers are equal");
    }
    else
    {
        Console.WriteLine("The integers are not equal");
    }
}
// EqualOrNot();
static void EvenOrOdd()
{
    Console.WriteLine("Enter your number:");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("The number is even");
    }
    else
    {
        Console.WriteLine("The number is odd");
    }
}
// EvenOrOdd();
static void LeapOrNot()
{
    Console.WriteLine("Enter your year");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 4 == 0)
    {
        Console.WriteLine("It is a leap year");
    }
    else
    {
        Console.WriteLine("It is not a leap year");
    }
}
LeapOrNot();
static void FizzBuzz()
{
    Console.WriteLine("Enter a number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 % 3 == 0 && num1 % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (num1 % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (num1 % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }

}

static void triangles()
{

    int side1 = Convert.ToInt32(Console.ReadLine());
    int side2 = Convert.ToInt32(Console.ReadLine());
    int side3 = Convert.ToInt32(Console.ReadLine());
    if (side1 == side2 && side2 == side3)
    {
        Console.WriteLine("equilateral");
    }
    else
    {
        if ((side1 + side2) < side3 || (side2 + side3) < side1 || (side3 + side1) < side2)
        {
            Console.WriteLine("impossible");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("isosceles");
        }

        else if (side1 != side2 && side1 != side3 && side3 != side1)
        {
            Console.WriteLine("scalene");
        }
    }
}
triangles();

