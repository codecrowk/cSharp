using System;

namespace MyApplication
{
  class Calculator 
  {
    public int addition (int numberOne, int numberTwo) {
      return numberOne + numberTwo;
    }

    public int sustract (int numberOne, int numberTwo) {
      return numberOne - numberTwo;
    }

    public int multiplication (int numberOne, int numberTwo) {
      return numberOne * numberTwo;
    }

    public int division (int dividend, int divisor) {
      return dividend / divisor;
    }
  }
  class Program
  {
    static void Main()
    {
      Calculator MyCalculator = new Calculator();
      Console.WriteLine("Bienvenido a su calculadora \nIngrese la operacion que desea realizar");

    }
  }
}