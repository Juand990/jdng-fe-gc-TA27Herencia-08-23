namespace TA27_M5
{
    internal class Empleado
    {
        protected string nombre;
        protected string apellido;
        protected double sueldo;
        public Empleado(string nNombre, string nApellido, double nSueldo)
        {
            this.Nombre = nNombre;
            this.Apellido = nApellido;
            this.Sueldo = nSueldo-1.15;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    }
}