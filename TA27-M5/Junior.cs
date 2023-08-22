namespace TA27_M5
{
    internal class Junior:Empleado
    {
        public Junior(string nNombre, string nApellido, double nSueldo)
            : base(nNombre, nApellido, nSueldo-(nSueldo*0.15))
        {
            
        }
    }
}