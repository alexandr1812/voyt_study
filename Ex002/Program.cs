// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.WriteLine("Введите 3 числа и узнайте какое больше");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.Write("max = ");
        Console.Write(a);
    }
}

if (a < b)
{
    if (c < b)
    Console.Write ("max = ");
    Console.Write (b);
}

if (a < c)
{
    if (b < c)
    {
         Console.Write("max = ");
         Console.Write(c);
    }
}
   