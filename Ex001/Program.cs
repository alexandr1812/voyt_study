// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите 2 числа и узнайте какое больше");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.Write(b);

}



if (b > a)
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.Write(a);
    
}
