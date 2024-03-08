// using System;

// namespace MyApplication
// {
//   class Calculator 
//   {
//     public int addition (int numberOne, int numberTwo) {
//       return numberOne + numberTwo;
//     }

//     public int sustract (int numberOne, int numberTwo) {
//       return numberOne - numberTwo;
//     }

//     public int multiplication (int numberOne, int numberTwo) {
//       return numberOne * numberTwo;
//     }

//     public int division (int dividend, int divisor) {
//       return dividend / divisor;
//     }
//   }
//   class Program
//   {
//     static void Main()
//     {
//       Calculator MyCalculator = new Calculator();
//       int result = 0;
//       // Incoming data
//       Console.Write("Bienvenido a su calculadora \n" +
//         "1. sumar\n" +
//         "2. restar\n" +
//         "3. multiplicar\n" +
//         "4. dividir\n" +
//         "Ingrese la operacion que desea realizar: "
//         );
//       int seletedOperation = int.Parse(Console.ReadLine());
//       Console.Write("Ingrese el numero uno: ");
//       int numberOne = int.Parse(Console.ReadLine());
//       Console.Write("Ingrese el numero dos: ");
//       int numberTwo = int.Parse(Console.ReadLine());

//       // Procedure
//       switch (seletedOperation)
//       {
//         case 1:
//           result = MyCalculator.addition(numberOne, numberTwo); 
//           break;
//         case 2:
//           result = MyCalculator.sustract(numberOne, numberTwo); 
//           break;
//         case 3:
//           result = MyCalculator.multiplication(numberOne, numberTwo); 
//           break;
//         case 4:
//           result = MyCalculator.division(numberOne, numberTwo); 
//           break;
//         default:
//           Console.WriteLine("Operacion invalida!");
//           break;
//       } 
//       Console.WriteLine($"El resultado de la operacion es {result}");
//     }
//   }
// }