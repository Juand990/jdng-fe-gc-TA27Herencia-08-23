namespace TA27_M6
{
    internal class Conductores : Persona
    {
        // M2-FASE 2
        protected string nombre;
        protected string apellido;
        protected string fechaNacimiento;
        protected LicenConducir licencia;

        public Conductores(string nNombre, string nApellido, string nFechaNacimiento, LicenConducir nLicencia)
        {
            this.nombre = nNombre;
            this.apellido = nApellido;
            this.fechaNacimiento = nFechaNacimiento;
            this.licencia = nLicencia;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        internal LicenConducir Licencia { get => licencia; set => licencia = value; }
    }
}