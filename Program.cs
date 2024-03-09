using System;

namespace MyApplication
{
  class QuickSort {
    public void init(){
      int pivot;
      int secodPointer = -1;
      int comparedNumber;
      int temporalNumber;
      int []numeros = {14, 7, 23, 12, 118, 5, 10, 2, 16, 25, 20, 3, 17, 9, 24, 11, 6, 
        15, 21, 8, 22, 4, 19, 13};
      int lastIndex = numeros.Length -1;
      pivot = numeros[lastIndex];

      for (int position = 0; position < numeros.Length; position++){
        comparedNumber = numeros[position];
        if (comparedNumber > pivot){
          secodPointer = position;
        } 
        else if ((comparedNumber < pivot) && (secodPointer >= 0)){
          temporalNumber = comparedNumber;
          // Making position change

        }
      }
    }
  }

  class InsertionShort 
  {
    public void Init (){
      int[] numeros = {14, 7, 23, 12, 118, 5, 10, 2, 16, 25, 20, 3, 17, 9, 24, 11, 6, 
        15, 21, 8, 22, 4, 19, 13};
      int key;
      // int key = numeros.First();
      for (int i = 0; i < numeros.Length; i++)
      {
        key = numeros[i +1];
        for (int x = 0; x < numeros.Length; x++)
        {
          int compareNum = numeros[x];
          if (key < compareNum){
            numeros[i] = key;
            numeros[x] = 0;  
          }
        }
      }
    }
  }
  class Program
  {
    public static void Main(){
    }
  }
}