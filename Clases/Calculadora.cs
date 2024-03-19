// El archivo y el nombre de la clase se deben llamar iguales
// Namespace debe coincidir con el nombre de la carpeta raiz
namespace Clases
{
  public static class Calculadora
  {
    public static int Sumar(int numero1, int numero2)
    {
      return numero1 + numero2;
    }

    public static int Restar(int numero1, int numero2)
    {
      return numero1 - numero2;
    }

    public static int Multiplicar(int numero1, int numero2)
    {
      return numero1 * numero2;
    }

    public static int Dividir(int numero1, int numero2)
    {
      return numero1 / numero2;
    }
  }

  public class Password 
  {
    public string GeneratePassword (){
      return "<PASSWORD>";
    }

    public string ValidatePassword(string password)
    {
      return password == "<PASSWORD>"? "Password correcta" : "Password incorrecta";
    }

    public string CheckPassworSecurity(){
      return "hola";
    }
  }
  public class Persona 
  {

  }
}