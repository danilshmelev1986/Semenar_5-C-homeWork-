// Урок 5. Функции и одномерные массивы


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [4]; 

// for (int i=0; i<array.Length; i++)
// {
//     array [i] = new Random().Next(100,999);
//     Console.Write (array [i]+" ");
//     }

// Console.WriteLine();

// int count = 0;

// for (int k=0; k<array.Length; k++)
// {
//     if (array [k]%2==0)
//     count++;
// }

// Console.WriteLine ("the number of even numbers " + count);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine ("give me a number");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] array1 = new int [num]; 

// for (int i=0; i<array1.Length; i++)
// {
//     array1 [i] = new Random().Next(0,9);
//     Console.Write (array1 [i]+"; ");
    
//  }
 
//  Console.WriteLine();
 
//  int sum = 0;
 
//  for (int i=0; i<array1.Length; i=i+2)
//  {
//   sum = sum + array1[i];
//  }
 
//  Console.WriteLine();
 
//  Console.WriteLine(sum);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine ("give me a number");
int num = Convert.ToInt32(Console.ReadLine());

if (num<=0)
{
    Console.WriteLine ("give me a positive number");
    return;
}

double [] array1 = new double [num]; 
Random random = new Random();

for (int i=0; i<array1.Length; i++)
{
   array1[i] = random.NextDouble() * 9;
    Console.Write (array1 [i]+"; ");
    
 }
 
 Console.WriteLine();
 
 
 double maxNum = array1[0];
        double minNum = array1[0];

        for (int i = 1; i < array1.Length; i++)
        {
            if (maxNum < array1[i])
            {
                maxNum = array1[i];
            }
            else if (minNum > array1[i])
            {
                minNum = array1[i];
            }
        }

        Console.WriteLine("minimal number is: " + minNum.ToString ("F2"));
        Console.WriteLine("maximum number is: " + maxNum.ToString ("F2"));
        
        double numberDifference = maxNum - minNum;
        
        Console.WriteLine("number difference is: " + numberDifference.ToString ("F2"));