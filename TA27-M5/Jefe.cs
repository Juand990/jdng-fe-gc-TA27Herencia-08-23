namespace TA27_M5
{
    internal class Jefe: Empleado
    {
        public Jefe(string nNombre, string nApellido, double nSueldo)
            :base( nNombre,  nApellido,  nSueldo+(nSueldo*1.5))
        {
            
        }
    }
}