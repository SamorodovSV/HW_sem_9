// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// string PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + ", " + PrintNumbersRecusiveType(start+1, end));
// }
// Console.Clear();
// Console.WriteLine("Программа вывода натуральных чисел от числа М до числа N.");
// Console.Write("Введите число M: ");
// int M = Convert.System.Single(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.System.Single(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(M, N)) ;



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         return end;
//     }
//     return start + SumNumbers(start + 1, end);
    
    
// }
// Console.Clear();
// Console.WriteLine("Программа, которая находит сумму натуральных чисел от числа М до числа N. ");
// Console.Write("Введите число М: ");
// int M = Convert.System.Single(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.System.Single(Console.ReadLine());
// Console.WriteLine($"M = {M}; N = {N} -> {SumNumbers(M,N)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return 0;
    }
    else if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m-1, 1);
    }
    else if(m > 0 && n > 0)
    {
        return AckermannFunction(m-1, AckermannFunction(m, n-1));
    }
    return AckermannFunction(m,n);
    
}

Console.Clear();
Console.WriteLine("Программа вычисления функии Аккермана А(m,n). ");
Console.Write("Введите число m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" A({M}, {N}) = {AckermannFunction(M,N)}");


