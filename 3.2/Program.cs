//Петросян 16 вар Средний уровень
Console.Write("Введите число n от 1 до 1000:");
int n = int.Parse(Console.ReadLine());
while (n > 1 && n < 1000)
{
    Console.Write("Введите число m:");
    int m = int.Parse(Console.ReadLine());
    int div = (n / m) * (n / m);
    Console.WriteLine($"Квадрат целочисленного деления:{div}");
}