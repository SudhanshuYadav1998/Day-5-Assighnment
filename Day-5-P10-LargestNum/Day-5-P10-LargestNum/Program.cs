Console.WriteLine("Enter the first Number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Third Number c");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine("A is largest");
}
else if (c > b && c > a)
{
    Console.WriteLine("C is largest");
}
else if (b > a && b > c)
{
    Console.WriteLine("B is Largest");
}
else
    Console.WriteLine("Numbers are Equal");