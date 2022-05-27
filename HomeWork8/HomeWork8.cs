void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] mass = new int[m, n];

FillArray (mass);
Print (mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int l = j + 1; l < mass.GetLength(0); l++)
        {
            if (mass[i, j] < mass[i, l])
            {
                int temp = mass[i, j];
                mass[i, j] = mass[i, l];
                mass[i, l] = temp;
            }
        }
    }
}
Print(mass);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int m = 4;
int n = 5;
int[,] mass = new int[m, n];

FillArray(mass);
Print(mass);
Console.WriteLine();

int min = mass.Length;
int str = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    int summ = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        summ=summ + mass[i, j];
    }
    if (summ < min)
    {
        min = summ;
        str = i+1;
    }
}
Console.WriteLine($"наименьшая сумма элементов = {min} ({str} строка)");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.Clear();
int[,,] mass = new int[3, 3, 3];
int[] massNew = new int[mass.Length];
bool RepeatNum;
int count = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(2); k++)
        {
            mass[i, j, k] = new Random().Next(1, 28);
            RepeatNum = false;
            for (int l = 0; l < count; l++)
                if (mass[i, j, k] == massNew[l])
                {
                    RepeatNum = true;
                    k--;
                    break;
                }
            if (RepeatNum == false)
            {
                massNew[count] = mass[i, j, k];
                count++;
                Console.Write($"{mass[i, j, k]} => [{i},{j},{k}]" + "|");
            }
        }
    }
   Console.WriteLine();
}

// Задача 62: Заполните спирально массив 4 на 4.
// 
  