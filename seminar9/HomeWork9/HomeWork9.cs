// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

void Gap(int m, int n)
{
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }
    else if (m > n)
    {
        Console.Write(m + " ");
        Gap(n, m - 1);
    }
    else
    {
        Console.Write(m + " ");
        Gap(n, m + 1);
    }

}
Gap(6, 2);
Gap(1, 5);
Gap(4, 8);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

int Summ(int n, int m)
{
    if(m > n) return 0;
    return Summ(n, m+1) + m;
}
int sum = Summ(n,m);
Console.Write($"Сумма элементов в промежутке от {m} до {n} равна ");
Console.WriteLine(sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int Akkerman(int m1, int n1)
{
    if (n1 < 0 || m1 < 0) return 0;
    else if (m1 == 0) return n1 + 1;
    else if (n1 == 0 && m1 > 0) return Akkerman(m1 - 1, 1);
    return Akkerman(m1 - 1, Akkerman(m1, n1 - 1));
}
int akk = Akkerman(m,n);
Console.Write($"Значение Аккермана A({m},{n})=");
Console.WriteLine(akk);