namespace Clases
{
  class Animal
  {
    protected string Name {get; set;} 
    protected string Color {get; set;} 
    protected string Tamanno {get; set;} 

    public Animal(string name, string color, string tamanno){
      Name = name;
      Color = color;
      Tamanno = tamanno;
    }

    public string Respirar (string animalName){
      return $"{animalName} esta respirando";
    }
  }
}