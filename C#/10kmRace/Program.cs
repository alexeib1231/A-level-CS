Console.WriteLine("Enter the minutes:");
int minutes = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the seconds:");
int seconds = Convert.ToInt32(Console.ReadLine());

double mps = 10000 / ((minutes * 60) + seconds);
double mph = mps * 3600 * 0.000621371;

Console.WriteLine(mps);
Console.WriteLine(mph);
