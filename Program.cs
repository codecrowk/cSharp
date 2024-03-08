using System;

namespace MyApplication
{
  class GradeCalculator 
  {
    static IDictionary<string, double> grades = new Dictionary<string, double>();

    public void addGrade(string gradeName, double gradeValue){
      grades.Add(gradeName, gradeValue);
    }


  }
  class Program
  {
    static void Main()
    {
      int gradesToRequest = 3;
      GradeCalculator GradeMethods = new GradeCalculator();
      for (int i = 0; i < gradesToRequest; i++){
        string gradeName = $"Nota{i+1}";
        Console.Write($"Ingrese la nota {i+1}: ");
        double gradeValue = double.Parse(Console.ReadLine());
        GradeMethods.addGrade(gradeName, gradeValue);
      }
    }
  }
}