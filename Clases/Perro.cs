namespace Clases
{
  class Perro : Animal
  {

    public Perro (string name, string color, string tamanno)
    : base(name, color, tamanno) {}

    public string Ladrar (){
      return $"{Name} esta ladrando";
    }
  }
}