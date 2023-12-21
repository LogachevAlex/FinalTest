// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void PrintNumbers(int m, int n)
{
    if (m == n) Console.Write($"{n}");
    else
    {
        Console.Write($"{m} ");
        PrintNumbers(m+1, n);
    }
}

Console.WriteLine("Input your M: ");
int user_M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your N: ");
int user_N = Convert.ToInt32(Console.ReadLine());
if (user_M < user_N) PrintNumbers(user_M, user_N);
else PrintNumbers(user_N, user_M);

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

