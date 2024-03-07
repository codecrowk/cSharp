// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     static double calculatorIMC (byte userKilograms, double userMeters){
//       double powMeters = Math.Pow(userMeters, 2);
//       double calculateIMC = userKilograms / powMeters;
//       return calculateIMC;
//     }

//     static void Main(string[] args)
//     {
//       byte userKilograms; 
//       double userMeters;
//       double imcResult;

//       Console.WriteLine("Bienvenido a la calculadora de IMC");
//       Console.Write("Ingrese su peso (KG): ");
//       userKilograms = Convert.ToByte(Console.ReadLine());
//       Console.Write("Ingrese su altura (Meters): ");
//       userMeters = Convert.ToDouble(Console.ReadLine());

//       imcResult = calculatorIMC(userKilograms, userMeters);
//       Console.WriteLine($"Su IMC es: {imcResult}");
//     }
//   }
// }