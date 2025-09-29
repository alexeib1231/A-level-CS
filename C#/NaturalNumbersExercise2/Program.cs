Console.WriteLine("Enter the number of natural numbers");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i<=n; i++)
{
    sum += i;
}
Console.WriteLine(sum);