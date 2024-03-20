namespace Clases
{
  class Persona
  {
    protected string Name;
    protected string Lastname;
    protected string Age;
    protected string Email;

    public Persona (string name, string lastName, string age, string email){
      Name = name;
      Lastname = lastName;
      Age = age;
      Email = email;
    }

    public string ShowData(){
      string personInfo = $"{Name} {Lastname}\n"
        + $"{Email} \n"
        + $"{Age}";
      return personInfo;
    } 

    public void UpdateData(string name, string lastName, string age, string email){
      Name = name;
      Lastname = lastName;
      Age = age;
      Email = email;
    }
  }
}