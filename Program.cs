//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* Console.WriteLine("Введите число A:");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int a2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {a1} в степени {a2} = {Math.Pow(a1, a2)}"); */


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/* Console.WriteLine("Введите число");
string a1 = Console.ReadLine();
int a2 = a1.Length;
int a3 = 0;
int a4 = int.Parse(a1);
for (int b1 = a2; b1 >= 0; b1--)
{
    a3 += a4 / (int)Math.Pow(10, b1);
    a4 = a4 % (int)Math.Pow(10, b1);
}
Console.WriteLine($"Сумма цифр в числе {a1} равна: {a3}"); */

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/* Console.WriteLine("Массив из 8 элементов");

int[] a1 = new int[8];
Random rand = new Random();
for (int b1 = 0; b1 < a1.Length; b1++)
{
    a1[b1] = rand.Next(); // диапазон случайных чисел в задаче не указан
    string number = Convert.ToString(a1[b1]);
    if (b1 == 0)
    {
        Console.Write($"[");
    }

    Console.Write($"{number} , ");

    if (b1 >= 7)
    {
        Console.Write($"]");
    }
} */



