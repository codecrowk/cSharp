//--- DOCS: https://www.wikihow.com/Calculate-Leap-Years
// using System;
// using System.Reflection.Metadata.Ecma335;

// namespace MyApplication
// {
//   class LeapYearCalculator
//   {
//     public bool init (int userYear){
//       // Make a validation chain
//       return divisibleByFour(userYear); 
//     }

//     static bool checkIfDivisible(int userDividentNumber, int userDivisorNumber){
//       bool isDivisible = userDividentNumber%userDivisorNumber == 0;
//       return isDivisible;
//     }

//     static bool divisibleByFour (int userYear){
//       bool isDivisible = checkIfDivisible(userYear, 4); 
//       if(isDivisible){
//         // Check if is also divisible by 100
//         return divisibleByOneHundred(userYear);
//       } else {
//         return false;
//       }
//     }

//     static bool divisibleByOneHundred (int userYear){
//       bool isDivisible = checkIfDivisible(userYear, 100); 
//       if(isDivisible){
//         // Check if is also divisible by 400
//         return divisibleByFourHundred(userYear);
//       } else {
//         return true;
//       }
//     }

//     static bool divisibleByFourHundred (int userYear){
//       bool isDivisible = checkIfDivisible(userYear, 400); 
//       if(isDivisible){
//         return true; 
//       } else {
//         return false;
//       }
//     }
//   }
//   class Program
//   {
//     public static void Main(){
//       LeapYearCalculator GetLeapYear = new LeapYearCalculator();
//       Console.Write("Ingrese el anno que desea conocer como bisiesto: ");
//       int userYear = int.Parse(Console.ReadLine());
//       bool isLeapYear = GetLeapYear.init(userYear);
//       if (isLeapYear){
//         Console.WriteLine($"El anno {userYear} es bisiesto");
//       } else {
//         Console.WriteLine($"El anno {userYear} no es bisiesto");
//       }
//     }
//   }
// }