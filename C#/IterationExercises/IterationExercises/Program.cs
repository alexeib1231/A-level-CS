using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;

static void Countdown(int n)
{

    while (n > 0)
    {
        Console.WriteLine(n);
        n -= 1;
        Thread.Sleep(1000);
    }
    Console.WriteLine("Blastoff!");
}
// Countdown(10);

void triangle(int n)
{
    for (int i = 0; i != n; i++)
    {
        for (int j = 0; j <=i; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
}
// triangle(10);

void grid(int r, int c)
{
    for (int j = 0; j < r; j++)
    {

        for (int i = 0; i < c; i++)
        {
            Console.Write("*━━━");
        }
        Console.WriteLine("*");
        for (int k = 0; k < c; k++)
        {   
            Console.Write("┃   ");
        }
        Console.WriteLine("┃");
    }
    for (int i = 0; i < c; i++)
        {
            Console.Write("*━━━");
        }
        Console.WriteLine("*");
}
// grid(15, 8);

void sentencereverse(string sentence)
{
    string[] words = sentence.Split(" ");

    for (int i = 0; i < (words.Length) / 2; i++)
    {
        string temp = " ";
        temp = words[i];
        words[i] = words[words.Length - (i + 1)];
        words[words.Length - (i + 1)] = temp;
    }
    foreach (string author in words)
    {
        Console.Write(author + " ");
    }
    Console.WriteLine();
}
// sentencereverse("I am real");

void menu(int n)
{

}
void Ask(int n)
{
    int sum = 0;
    double median = 0.0;
    List<int> nums = new List<int>();
    for (int i = 0; i < n; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        nums.Add(num);
        nums.Sort();
        sum += num;
    }

    int mid = nums.Count() / 2;
    if (nums.Count() % 2 == 0)
    {
        median = ((double)nums[mid] + nums[mid - 1]) / 2;
    }
   else
    {
        median = nums[mid];
    }
    Console.WriteLine($"The sum of your numbers is {sum}");
    Console.WriteLine($"The mean of your numbers is {sum / n}");
    Console.WriteLine($"The median of your numbers is {median}");
}

// Ask(nums);

bool IsPrime(int n)
{
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
// Console.WriteLine(IsPrime(101));

bool IsPerfect(int n)
{
    int cnt = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            cnt += i;
        }
    }
    if (cnt == n)
    {
        return true;
    }
    else
    {
        return false;
    }
}
// Console.WriteLine(IsPerfect(28));
bool IsAbundant(int n)
{
    int cnt = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            cnt += i;
        }
    }
    if (cnt > n)
    {
        return true;
    }
    else
    {
        return false;
    }
}
// Console.WriteLine(IsAbundant(12));

bool IsFriendly(int n, int p)
{
    int cnt1 = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            cnt1 += i;
        }
    }
    int cnt2 = 0;
    for (int i = 1; i < p; i++)
    {
        if (p % i == 0)
        {
            cnt2 += i;
        }
    }
    if ((double)cnt1 / n == (double)cnt2 / p)
    {
        return true;
    }
    else
    {
        return false;
    }
}
// Console.WriteLine(IsFriendly(30, 140));

int[] nums = { 1, 2, 5, 8, 10, 123, -3 };
int BinarySearch(int[] nums, int target)
{
    Array.Sort(nums);
    int left = 0;
    int right = nums.Length - 1;

    while(left<=right)
    {
        int mid=left +(right-left)/2;

        if(nums[mid] == target)
        {
            return mid;
        }
        else if(nums[mid] <target)
        {
            left=mid+1; 
        }
        else
        {
            right=mid-1; 
        }
    }

    return -1;
}