//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//   какое число большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

//   Console.WriteLine("Введите первое число: ");
//   int a = Convert.ToInt32 (Console.ReadLine());
//   Console.WriteLine("Введите второе число: ");
//   int b = Convert.ToInt32 (Console.ReadLine());

//   if(a > b)
//   {
//      Console.WriteLine($"max = {a}"); 
//   }
//   else
//  {
//      Console.WriteLine($"max = {b}");
//   }

// Задача 4: Напишите программу, которая принимает на
//  вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//  Console.Write("Введите a: ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите b: ");
//  int b = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите c: ");
//  int c = Convert.ToInt32(Console.ReadLine());

//  int max = a;
//  if (b > a) max = b;
//  if (c > max) max = c;
  
//   Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// вляется ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.Write("input N: ");
//  int num = Convert.ToInt32(Console.ReadLine());

//  if(num % 2 == 0) Console.WriteLine("да");
//   else Console.WriteLine("нет");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//В любом случае

// Console.Write("N: ");
// int N = Convert.ToInt32(Console.ReadLine());
            
// // 1-е решение
// for (int i = 2; i <= N; i += 2)
// {
//   Console.WriteLine(i);
// }

//2-е решение
// for (int i = 1; i <= N; i++)
// {
//   if(i % 2 == 0) 
//   {
//     Console.WriteLine(i);
//   }
// }
