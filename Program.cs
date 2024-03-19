using Clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");
app.MapGet("juegos/loQueQuiero", () => "Hello World!");
app.MapGet("calculadora/sumar", () => {
  int numero1 = 20;
  int numero2 = 10;
  int resultado = Calculadora.Sumar(numero1, numero2);
  return $"El resultado de sumar {numero1} con {numero2} es: {resultado}";
});

app.MapGet("calculadora/restar", () => {
  int numero1 = 20;
  int numero2 = 10;
  int resultado = Calculadora.Restar(numero1, numero2);
  return $"El resultado de restar {numero1} con {numero2} es: {resultado}";
});

app.MapGet("calculadora/multiplicar", () => {
  int numero1 = 20;
  int numero2 = 10;
  int resultado = Calculadora.Multiplicar(numero1, numero2);
  return $"El resultado de multiplicar {numero1} con {numero2} es: {resultado}";
});

app.MapGet("calculadora/dividir", () => {
  int numero1 = 20;
  int numero2 = 10;
  int resultado = Calculadora.Dividir(numero1, numero2);
  return $"El resultado de dividir {numero1} con {numero2} es: {resultado}";
});

app.MapGet("person/greeting", () => {
  Person person = new Person();
  string name = "Jose";
  string lastname = "Antoni";
  return person.Greeting(name, lastname);
});

app.MapGet("person/count_sentence", () => {
  Person person = new Person();
  string sentence = "Bueno dias mi nombre es Mario Orvaldo, tengo 34 annos de edad";
  string sentenceTest = "cinco";
  return person.GetSentenceLength(sentence);
});

app.MapGet("person/greeting", () => {
  Person person = new Person();
  string name = "Jose";
  string lastname = "Antoni";
  return person.Greeting(name, lastname);
});
app.Run();
