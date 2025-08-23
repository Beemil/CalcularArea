

namespace CalcularArea
{
    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public Circulo(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

    }
    
}
