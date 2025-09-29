using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

int digitsum(string n)
{
    int sum = 0;
    for (int i = 0; i < n.Length; i++)
    {
        sum += Convert.ToInt32(n[i].ToString());
    }
    return sum;
}

Console.WriteLine(digitsum("66"));

bool isPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {

        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(isPrime(8));

int numspace(string s)
{
    int cnt = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            cnt++;
        }
    }
    return cnt;
}
Console.WriteLine(numspace("lots of spaces"));

int numswap(ref int n1, ref int n2)
{
    int temp = n1;
    n1 = n2;
    n2 = temp;
    return 0;
}
int a = 5;
int b = 6;
numswap(ref a, ref b);

string tobinary(string n)
{
    return "0b" + Convert.ToString(Convert.ToInt32(n), 2);
}
string tohex(string n)
{
    return "0x" + Convert.ToString(Convert.ToInt32(n), 16);
}
Console.WriteLine(tobinary("10"));
Console.WriteLine(tohex("257"));