namespace TA27_M5
{
    internal class Manager:Empleado
    {
        public Manager(string nNombre, string nApellido, double nSueldo)
            : base(nNombre, nApellido, nSueldo+(nSueldo*1.1))
        {
            
        }
    }
}