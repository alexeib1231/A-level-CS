Console.WriteLine("Enter an integer:");

int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i,2} x {num,3} = {i * num,4}");

}