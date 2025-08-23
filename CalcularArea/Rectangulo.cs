

namespace CalcularArea
{
    public class Rectangulo : Forma
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(string nombre, double ancho, double alto)
        {
            Nombre = nombre;
            Ancho = ancho;
            Alto = alto;
        }
        public override double CalcularArea()
        {
            return Ancho * Alto;

        }
    }
}
