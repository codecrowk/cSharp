// using System;

// namespace MyApplication
// {
//   class GradeCalculator 
//   {
//     static IDictionary<string, double> grades = new Dictionary<string, double>();

//     public void addGrade(string gradeName, double gradeValue){
//       grades.Add(gradeName, gradeValue);
//     }

//     public double getGradeAverage(){
//       int gradesLength = grades.Count;
//       double gradesValueAcomulation = 0;

//       for (int i = 0; i < gradesLength; i++){
//         gradesValueAcomulation += grades.ElementAt(i).Value;
//       }
//       double averageCalculation = calculateAverage(gradesValueAcomulation, gradesLength); 
//       return averageCalculation;
//     }

//     static double calculateAverage (double gradesValueAcomulation, int gradesLength){
//       double averageCalculation = gradesValueAcomulation/gradesLength;
//       return averageCalculation;
//     }
//   }

//   class GradeValidation 
//   {
//     public void getWinLoseGrade (double userGrade){
//       int notaMinima = 3;
//       if (userGrade >= notaMinima) {
//         Console.WriteLine("Usted gano la materia");
//       } else {
//         Console.WriteLine("Usted perdio la materia");
//       }
//     }

//     public bool isValidGrade (double userGrade){
//       int minGrade = 0,
//         maxGrade = 5;
//       if ((userGrade >= minGrade) && (userGrade < maxGrade)) {
//         return true;
//       } else {
//         return false;
//       }
//     }
//   }

//   class Program
//   {
//     static void Main()
//     {
//       int gradesToRequest = 4;
//       GradeCalculator GradeMethods = new GradeCalculator();
//       GradeValidation ValidateGrade = new GradeValidation();

//       for (int i = 0; i < gradesToRequest; i++){
//         string gradeName = $"Nota{i+1}";
//         Console.Write($"Ingrese la nota {i+1}: ");
//         double insertedGrade = double.Parse(Console.ReadLine());

//         // Check if is a valid grade
//         bool isValidGrade =  ValidateGrade.isValidGrade(insertedGrade);
//         if (isValidGrade){
//           GradeMethods.addGrade(gradeName, insertedGrade);
//         } else {
//           i --;
//         }
//       }

//       double averageCalculation = GradeMethods.getGradeAverage();
//       Console.WriteLine($"El total ponderado de las notas es: {averageCalculation}");
//       ValidateGrade.getWinLoseGrade(averageCalculation);
//     }
//   }
// }