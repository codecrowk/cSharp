// using System;

// namespace MyApplication
// {
//   class NumberClasificator 
//   {
//     static bool getPositiveNegative (int userNumber){
//       bool isPositive = userNumber > 0;
//       return isPositive;
//     }
    
//     static bool getPair (int userNumber){
//       bool isPairNumber = userNumber % 2 == 0;
//       return isPairNumber;
//     }

//     static bool isCeroNumber (int userNumber){
//       bool isCero = userNumber == 0;
//       return isCero;
//     }

//     public string clasificate (int userNumber){
//       string message;
//       if (isCeroNumber(userNumber)){
//         message = "El numero que ingreso es cero";
//         return message;
//       }
      
//       if (getPair(userNumber)){
//         message = $"El numero {userNumber} es par";
//       }
//       else {
//         message = $"El numero {userNumber} es inpar";
//       }
      
//       if (getPositiveNegative(userNumber)){
//         message += " y es positivo";
//       }
//       else {
//         message += " y es negativo";
//       }
//       return message;
//     }
//   }
//   class Program
//   {
//     static void Main()
//     {
//       NumberClasificator clasificateNumber = new NumberClasificator(); 
      
//       Console.Write("Hola por favor ingresa un numero para clasificarlo: ");
//       int userNumber = int.Parse(Console.ReadLine());
//       string clasification = clasificateNumber.clasificate(userNumber);
//       Console.WriteLine(clasification);
//     }
//   }
// }