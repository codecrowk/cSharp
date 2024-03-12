// using System;

// namespace MyApplication
// {
//   class Program
//   {
//     class CalcularPropina 
//     {
//       public double calcular (double userTotalCuenta, double userPorcentajePropina) {
//         // 10% = 0.1 (10/100)
//         double porcentajePropina = sacarPorcentaje(userPorcentajePropina);
//         double totalPropina = userTotalCuenta * porcentajePropina;
//         double totalFactura = userTotalCuenta + totalPropina;
//         return totalFactura;
//       }

//       static double sacarPorcentaje (double userPorcentaje){
//         double porcentaje = userPorcentaje/100;
//         return porcentaje;
//       }
//     }
//     public static void Main(){
//       CalcularPropina CalculadoraPropina = new CalcularPropina();

//       Console.Write("Ingrese el total de la cuenta: ");
//       double totalCuenta = double.Parse(Console.ReadLine());
//       Console.Write("Ingrese el porcentaje de propina que desea dejar: ");
//       double totalPropina = double.Parse(Console.ReadLine());
//       double totalAcomulado = CalculadoraPropina.calcular(totalCuenta, totalPropina);
//       Console.WriteLine($"El total de la cuenta es: {totalAcomulado}");
//     }
//   }
// }