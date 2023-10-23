// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите N: ");
//         int N = int.Parse(Console.ReadLine());

//         Recurs(N);

//         Console.ReadKey();
//     }

//     static void Recurs(int N)
//     {
//         Console.WriteLine(N);
//         if (N == 1)
//             return;
//         Recurs(N - 1);
//     }
// }  

     
// // Задача 66: Задайте значения M и N.
// //  Напишите программу, которая найдёт сумму
// // натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// using System;

// class Program
// {
//     static public void Main()
//     {
//         Console.Write("Введите M: ");
//         int M = int.Parse(Console.ReadLine());
//         Console.Write("Введите N: ");
//         int N = int.Parse(Console.ReadLine());
        
//         Console.WriteLine(Sum(M, N));
    
//         Console.ReadKey();
//     }

    
//     static int Sum(int M, int N)
//     {
//         int sum = 0;
//         for (int i = M; i <= N; i++)
//         {
//             sum += i;
//         }
//         return sum;
//     }
// }

// // Задача 68: Напишите программу вычисления 
// // функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

// using System;

// public class Program
// {
//     static public void Main()
//     {
//         Console.Write("Введите M: ");
//         int M = int.Parse(Console.ReadLine());
//         Console.Write("Введите N: ");
//         int N = int.Parse(Console.ReadLine());

//         Console.WriteLine(A(M, N));

//         Console.ReadKey();
//     }

//     static int A(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (m != 0 && n == 0)
//             return A(m - 1, 1);
//         else
//             return A(m - 1, A(m, n - 1));
//     }
// }
