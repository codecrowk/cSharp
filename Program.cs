using System;

namespace MyApplication
{
  class ConverDateToArray 
  {
    // dd/mm/yyyy
    // 22/10/2002
    // [22, 10, 2002]
    /*
      day: 22,
      mount: 10,
      year: 2002
    */
    ConverDateToArray (string userDate) {
      string[] getDateArray = userDate.Split("/");

      int year = int.Parse(getDateArray[0]);
      for (int i = 0; i < getDateArray.Length; i++)
      {
        Console.WriteLine(getDateArray[i]);
      }
    }

  }
  class Program
  {
    public static void Main(){
      string userDate = "22/10/2002";

    }
  }
}