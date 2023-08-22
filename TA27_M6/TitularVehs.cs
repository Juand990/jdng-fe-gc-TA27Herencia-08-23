namespace TA27_M6
{
    internal class TitularVehs : Conductores
    {
        // M2-FASE 2
        private bool seguro;
        private bool garaje;

        public TitularVehs(string nombre, string apellido, string fechaNacimiento, LicenConducir licencia, bool nSeguro, bool nGaraje)
            : base(nombre, apellido, fechaNacimiento, licencia)
        {
            this.Seguro = nSeguro;
            this.Garaje = nGaraje;
        }
        public bool Seguro { get => seguro; set => seguro = value; }
        public bool Garaje { get => garaje; set => garaje = value; }
    }
}