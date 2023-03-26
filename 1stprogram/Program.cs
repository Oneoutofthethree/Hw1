Console.WriteLine("Введите числа:");
int N = int.Parse(Console.ReadLine());

int F = int.Parse(Console.ReadLine());

if (N > F)
{
    Console.WriteLine("Максимум равен:");
    Console.WriteLine(N);
    Console.WriteLine("Минимум равен:");
    Console.WriteLine(F);
}
if (N < F)
{
    Console.WriteLine("Максимум равен:");
    Console.WriteLine(F);
    Console.WriteLine("Минимум равен:");
    Console.WriteLine(N);  
}