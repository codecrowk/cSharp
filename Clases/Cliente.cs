namespace Clases
{
  class Cliente : Persona
  {
    private string CodigoEmpleado;

    public Cliente (string name, string lastName, string age, string email, string codigoEmpleado)
    : base(name, lastName, age, email)
    {
      UpdateData(name, lastName, age, email, codigoEmpleado);
    }

    public string ShowData(){
      string personInfo = $"{Name} {Lastname}\n"
        + $"{Email} \n"
        + $"{Age} \n"
        + $"{CodigoEmpleado}";
      return personInfo;
    } 

    public void UpdateData (string name, string lastName, string age, string email, string codigoEmpleado){
      Name = name;
      Lastname = lastName;
      Age = age;
      Email = email;
      CodigoEmpleado = codigoEmpleado;
    }

    public int CalcularPuntos (){
      return 0;
    }
  }
}