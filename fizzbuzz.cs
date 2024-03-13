// // Escribir un programa que muestre en pantalla los números del 1 al 100, sustituyendo los múltiplos de 3 por la palabra “fizz”, los múltiplos de 5 por “buzz” y los múltiplos de ambos, es decir, los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.
// using System;

// namespace HelloWorld
// {
//   class Fizzbuzz 
//   {
//     public void init (){
//       for (int numero = 1; numero <= 100; numero++){
//         string changedNumber;
//         if (isMultiple(numero, 15)){
//           changedNumber = "fizzbuzz";
//         }
//         else if (isMultiple(numero, 3)){
//           changedNumber = "fizz";
//         }
//         else if (isMultiple(numero, 5)){
//           changedNumber = "buzz";
//         }
//         else {
//           changedNumber = Convert.ToString(numero);
//         }
//         Console.WriteLine(changedNumber);
//       }
//     }
    
//     static bool isMultiple (int userNumber, int userMultiple){
//       bool validateNumber = userNumber % userMultiple == 0;
//       return validateNumber;
//     }
//   }
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Fizzbuzz MakeFizzbuzz = new Fizzbuzz();
//       MakeFizzbuzz.init();
//     }
//   }
// }
