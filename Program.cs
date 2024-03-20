using Clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("persona", () => {
  Persona Usuario1 = new Persona("Jose", "Alvarez", "22", "jose@example.com");
  return Usuario1.ShowData();
});

app.MapGet("persona_updated", () => {
  Persona Usuario1 = new Persona("Jose", "Alvarez", "22", "jose@example.com");
  Usuario1.UpdateData("Maria", "Trujillo", "50", "mariano@example.com");
  return Usuario1.ShowData();
});

app.MapGet("empleado_updated", () => {
  Empleado Usuario1 = new Empleado("Jose", "Alvarez", "22", "jose@example.com", "2110");
  // Usuario1.updateData("Maria", "Trujillo", "50", "mariano@example.com");
  return Usuario1.ShowData();
});

app.MapGet("perro", () => {
  Perro TobbyPerruno = new Perro ("Tobby", "Negro", "20cm");
  return TobbyPerruno.Ladrar();
});
app.Run();
