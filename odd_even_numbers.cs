// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     public static void Main()
//     {
//       List<int> numberList = new List<int>();
//       Console.Write("Ingrese la cantidad de numeros: ");
//       int numbersToCompare = int.Parse(Console.ReadLine());

//       for (int i = 0; i < numbersToCompare; i++)
//       {
//         Console.Write($"Ingrese el numero {i+1}: ");
//         int getNumber = int.Parse(Console.ReadLine());
//         numberList.Add(getNumber);
//       }

//       bool includesEven = numberList.Exists(number => number%2 == 1);
//       if (includesEven)
//       {
//         Console.WriteLine("No todos los numeros son pares");
//       } else {
//         Console.WriteLine("Todos los numeros son pares");
//       }
//     }
//   }
// }