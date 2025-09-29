Console.WriteLine("Enter the radius of the circle:");

double radius = double.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(radius, 2);
double circumference = 2 * Math.PI * radius;

Console.WriteLine($"Area: {area:F2}");
Console.WriteLine($"Circumference: {circumference:F2}");