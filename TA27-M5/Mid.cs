namespace TA27_M5
{
    internal class Mid:Empleado
    {
        public Mid(string nNombre, string nApellido, double nSueldo)
            : base(nNombre, nApellido, nSueldo - (nSueldo * 0.10))
        {
            
        }
    }
}