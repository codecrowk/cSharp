// using System;

// namespace MyApplication
// {
//   class ConverDateToArray 
//   {
//     // dd/mm/yyyy
//     // 22/10/2002
//     // [22, 10, 2002]
//     /*
//       day: 22,
//       mount: 10,
//       year: 2002
//     */
//     ConverDateToArray (string userDate) {
//       string[] getDateArray = userDate.Split("/");

//       int year = int.Parse(getDateArray[0]);
//       for (int i = 0; i < getDateArray.Length; i++)
//       {
//         Console.WriteLine(getDateArray[i]);
//       }
//     }

//   }
//   class Program
//   {
//     public static void Main(){
//       string userDate = "22/10/2002";

//     }
//   }







//   class Movil 
//   {
//     public string Pantalla; 
//     public List<string> Botones; 
//     public List<string> Camaras; 
    
//     public static void Main()
//     {
//       SubirVolumen();
//     }
    
//     public static void TomarFoto()
//     {

//     }

//     public static void SubirVolumen(int cantidad)
//     {
//       aijsdan slasnd kasvas 100Dc 
//     }




//   }

//   class Iphone : Movil {

//     public static void Main()
//     {
//       Movil.SubirVolumen(2);
//     }

//     public static void FaceID()
//     {

//     }



//   }


//   class Samsung : Movil {

//     public static void Main()
//     {
//       Movil.SubirVolumen(3);
//     }

//     public static void FaceID()
//     {

//     }



//   }

//   /// ejemplo 2 interfaces 




//   interface IUsuario
//   {
//     string nombre {get;set;}
//     int  edad {get;set;}
//     string documento {get;set;}
//     string correo {get;set;}
//     string password {set;}
//   }


//   class usuario : IUsuario
//   {
//     public string nombre {get;set;}
//     public int  edad {get;set;}
//     public string documento {get;set;}
//     public string correo {get;set;}
//     private string password {set;}


//       public static void Main(string[] args)
//       {
        
//       }

//       public static void CrearUsuario()
//       {

//         string rNombre =  Console.ReadLine();
//         int  redad  = Console.ReadLine();
//         string rdocumento  = Console.ReadLine();
//         string rcorreo  = Console.ReadLine();
//         string rpassword = Console.ReadLine();
        
//         IUsuario user = new IUsuario() {rNombre,redad,rdocument,rcorreo,rpassword} 



//       }


//   }
// }
// }