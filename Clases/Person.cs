namespace Clases
{
  public class Person 
  {
    public string Greeting (string userName, string userLastname){
      return $"Welcome {userName} {userLastname}";
    }

    public int GetSentenceLength (string userSentence){
      Sentence sentence = new Sentence();
      int sentenceLength = sentence.GetSentenceLength(userSentence);
      return sentenceLength;
    }

    public string ClasificatePasswordSecurity (string userPassword){
      Password password = new Password();
      string passwordSecurity = password.CheckPassworSecurity(userPassword);
      return passwordSecurity;
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

    public string CheckPassworSecurity(string password){
      return "hola";
    }
  }

  public class Sentence
  {
    public int GetSentenceLength (string sentence){
      int sentenceLength = sentence.Length;
      return sentenceLength;
    }

    public string FindWordSentece (string word, string sentence){
      return "0";
    }
  }
}