
void PrintNumbers(int m, int n) //Метод, который выводит числа в промежутке от m до n рекурсивно
{
    if (m == n) Console.Write($"{n}");
    else
    {
        Console.Write($"{m} ");
        PrintNumbers(m + 1, n);
    }
}

int Ackermann(int m, int n) //Метод реализует функцию Аккермана
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int[] CreateArray(int length) //Метод создает рандомный массив чисел
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array) //Метод выводит на экран массив чисел
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintReverseArray(int[] array, int length) //Метод выводит на экран массив чисел с конца рекурсивно
{
    if (length == 1) Console.Write($"{array[0]}");
    else
    {
        Console.Write($"{array[length - 1]} ");
        PrintReverseArray(array, length - 1);
    }
}

// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

Console.WriteLine("Input your M: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your N: ");
int userN = Convert.ToInt32(Console.ReadLine());
if (userM < userN) PrintNumbers(userM, userN);
else PrintNumbers(userN, userM);

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

Console.WriteLine();
Console.WriteLine($"{Ackermann(3, 2)}");
Console.WriteLine($"{Ackermann(2, 3)}");

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

Console.WriteLine("Please, input the length of random array: ");
int userLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateArray(userLength);
PrintArray(userArray);
PrintReverseArray(userArray, userLength);
