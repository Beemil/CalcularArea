using CalcularArea;

Circulo circulo = new Circulo("Círculo", 7);
Rectangulo rectangulo = new Rectangulo("Rectángulo", 8, 12);

List<Forma> formas = new List<Forma>();

formas.Add(circulo);
formas.Add(rectangulo);

foreach (var forma in formas)
{
    Console.WriteLine($"El área del {forma.Nombre} es: {forma.CalcularArea()}");
}
