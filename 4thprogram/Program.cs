Console.WriteLine("Введите предельное значение:");
int N = int.Parse(Console.ReadLine());
int a = 1;
while (a <= N)
{if (a%2==0)
    Console.WriteLine(a);
a = a + 1;
}
