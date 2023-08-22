namespace TA27_M5
{
    internal class Senior:Empleado
    {
        public Senior(string nNombre, string nApellido, double nSueldo)
            : base(nNombre, nApellido, nSueldo - (nSueldo * 0.05))
        {
            
        }

    }
}