namespace Clases
{
  class Gato : Animal
  {

    public Gato (string name, string color, string tamanno)
    : base(name, color, tamanno) {}

    public string Maullar (){
      return $"{Name} esta maullado";
    }
  }
}