// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
//числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
int remainder;

while (current < N)
{
    remainder = current % 2;
    if (remainder == 0)
    {
        Console.WriteLine($"{current}");
    }
    current++;
}
