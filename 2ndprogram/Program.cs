Console.WriteLine("Введите числа:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if(b>a) max =b;
if(c>b) max =c; 
string tmp = $"Наибольшее число:{max}";

Console.WriteLine(tmp);