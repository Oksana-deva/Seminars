// // // Задача 34: Задайте массив заполненный 

// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество
//  чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

 static int[] CreateRandomArray(int length)
 {
     int[] array = new int[length];
     Random r = new Random();

     for (int i = 0; i < length; i++)
     {
         array[i] = r.Next(100, 1000);
     }

     return array;
 }

int[] ints = CreateRandomArray(12);

int n = 0;

for (int i = 0; i < ints.Length; i++)
 {
     if (ints[i] % 2 == 0)
     {
     n++;
     }
 }

 for (int i = 0; i < ints.Length; i++)
 {
         Console.Write(ints[i] + " ");
 }

     Console.WriteLine(": " + n + " чётных");
 
//  
// // // Задача 36: Задайте одномерный массив,
// //  заполненный случайными числами. 
// //  Найдите сумму элементов,
// // стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0
// static int[] CreateRandomArray(int length)
// {
//     int[] array = new int[length];
//     Random r = new Random();

//     for (int i = 0; i < length; i++)
//     {
//         array[i] = r.Next();
//     }

//         return array;
// }


//     int[] ints = CreateRandomArray(12);

//     int n = 0;

//     for (int i = 0; i < ints.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//     n += ints[i];            
//     }
        
// }

//     for (int i = 0; i < ints.Length; i++)
// {
//         Console.Write(ints[i] + " ");
// }

//     Console.WriteLine("\nСумма: " + n);
       

// // // Задача 38: Задайте массив вещественных чисел.
// //  Найдите разницу между максимальным
// //   и минимальным элементов массива.
// // // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };

//        double max = array[0], min = array[0];

//        for (int i = 0; i < array.Length; i++)
//        {
//        if (array[i] > max) max = array[i];
//        if (array[i] < min) min = array[i];
//        }

//        Console.WriteLine("Разница: " + (max - min));
       


