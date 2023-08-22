namespace TA27_M6
{
    internal class LicenConducir
    {
        // M2-FASE 2
        private int id;
        private int tipo;
        private string nombre;
        private string fechaCaducidad;
        public LicenConducir(int nId, int nTipo, string nNombre, string nFechaCad)
        {
            this.Id = nId;
            this.Tipo = nTipo;
            this.Nombre = nNombre;
            this.FechaCaducidad = nFechaCad;
        }

        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }
    }
}