// using System;

// namespace MyApplication
// {
//   class MountInterface 
//   {
//       static IDictionary<string, int> cities = new Dictionary<string, int>(){
//       // mes - dias
// 			{"enero", 31},
// 			{"febrero", 28},
// 			{"marzo", 31},
// 			{"abril", 30},
// 			{"mayo", 31},
// 			{"junio", 30},
// 			{"julio", 31},
// 			{"agosto", 31},
// 			{"septiembre", 30},
// 			{"octubre", 31},
// 			{"noviembre", 30},
// 			{"diciembre", 31}
// 		};

//     public string getMountByNumber (int userNumber){
//       // Dictionary<string, int>.KeyCollection keyColl = cities.Keys;
//       List<string> cityKeyList =  new List<string>(cities.Keys);
//       string mountResult = cityKeyList[userNumber];
//       return mountResult;
//     }

//     public int getMountDays (string userMountName){
//       int dayOfMount = cities[userMountName];
//       return dayOfMount;
//     }
//   }
//   class Program
//   {
//     static void Main()
//     {
//       MountInterface yearMounts = new MountInterface();
//       Console.Write("Ingrese el numero del mes en el que desea conocer sus dias: ");
//       int selectedMount = int.Parse(Console.ReadLine());
//       string mountName = yearMounts.getMountByNumber(selectedMount -1);
//       int mountDays = yearMounts.getMountDays(mountName);
//       Console.WriteLine($"El mes de {mountName} tiene {mountDays}");
//     }
//   }
// }