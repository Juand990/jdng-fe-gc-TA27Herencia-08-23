using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TA27_M6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // M3-FASE 1
            //Listas class Vehiculos y class Conductores
            List<Vehiculos> listaVehiculos = new List<Vehiculos>();
            List<Conductores> listaPersonas = new List<Conductores>();
            //---------------------------
            // M3-FASE 1
            Menu(listaVehiculos, listaPersonas); //MENU
        }

        private static void Menu(List<Vehiculos> listaVehiculos, List<Conductores> listaPersonas)
        {
            //Lista de class LicenConducir
            List<LicenConducir> listaLinc = new List<LicenConducir>();
            LicenConducir licCo1 = new LicenConducir(1, 1, "coche", "31-12-2030");
            listaLinc.Add(licCo1);
            licCo1 = new LicenConducir(2, 2, "moto", "31-12-2030");
            listaLinc.Add(licCo1);
            licCo1 = new LicenConducir(3, 3, "camion", "31-12-2030");
            listaLinc.Add(licCo1);
            //-------------OPCIONES MENU--------------
            Console.WriteLine("Que vas hacer??");
            Console.WriteLine("Crear Conductores: 1");
            Console.WriteLine("Crear Vehiculos: 2");
            Console.WriteLine("Asignar Vehiculo: 3");
            Console.WriteLine("Cerrar: 0");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    CrearConductor(listaLinc, listaPersonas); //creamos conductores
                    Menu(listaVehiculos, listaPersonas);
                    break;
                case 2:
                    // M1-FASE 3
                    Console.WriteLine("Que Vehiculo vas a crear?? ");
                    Console.WriteLine("Coche: 1");
                    Console.WriteLine("Moto: 2");
                    Console.WriteLine("Camion: 3");
                    int vehiculo = int.Parse(Console.ReadLine());
                    CrearVehiculo(listaVehiculos, vehiculo); //creamos vehiculos
                    Menu(listaVehiculos, listaPersonas);
                    break;
                case 3:
                    AsignarVeh(listaVehiculos, listaPersonas); //asignamos vehiculos
                    Menu(listaVehiculos, listaPersonas);
                    break;
                default:
                    Console.ReadKey();
                    break;
            }
        }
        private static void AsignarVeh(List<Vehiculos> listaVehiculos, List<Conductores> listaPersonas)
        {
            Console.WriteLine("Introduce la MATRICULA del Vehiculo a asignar:");
            string mat = Console.ReadLine();
            Console.WriteLine("Tiene Seguro??");
            Console.WriteLine("Si: 1");
            Console.WriteLine("No: 2");
            int respSeg = int.Parse(Console.ReadLine());
            bool seguro = false;
            if (respSeg == 1)
            {
                seguro = true;
            }
            Console.WriteLine("Tiene Garaje?");
            Console.WriteLine("Si: 1");
            Console.WriteLine("No: 2");
            int respGar = int.Parse(Console.ReadLine());
            bool garaje = false;
            if (respGar == 1)
            {
                garaje = true;
            }
            Console.WriteLine("Que licencia tienes??");
            Console.WriteLine("Coches / Motos / Camiones");
            string TipoLicencia = Console.ReadLine();
            for (int k = 0; k < listaVehiculos.Count; k++)
            {
                if (listaVehiculos[k].GetType().Name == TipoLicencia)
                {
                    TitularVehs t = null;
                    for (int i = 0; i < listaVehiculos.Count; i++)
                    {
                        if (listaVehiculos[i].GetMatricula() == mat)
                        {
                            Console.WriteLine("Introduce el Nombre:");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Introduce el Apellido:");
                            string ape = Console.ReadLine();
                            List<Conductores> lsPers = new List<Conductores>();
                            for (int j = 0; j < listaPersonas.Count; j++)
                            {
                                if (listaPersonas[j].Nombre == nombre && listaPersonas[j].Apellido == ape)
                                {
                                    t = new TitularVehs(listaPersonas[j].Nombre,
                                                        listaPersonas[j].Apellido,
                                                        listaPersonas[j].FechaNacimiento,
                                                        listaPersonas[j].Licencia,
                                                        seguro, garaje);
                                    Conductores c = new Conductores(listaPersonas[j].Nombre,
                                                           listaPersonas[j].Apellido,
                                                           listaPersonas[j].FechaNacimiento,
                                                           listaPersonas[j].Licencia);
                                    lsPers.Add(c);
                                    listaVehiculos[i].SetConductores(lsPers); //asignamos lista conductores
                                }
                            }
                            listaVehiculos[i].SetTitular(t); //asignamos titular al vehiculo                                                       
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Licencia erronea");
                }
            }

            Console.Clear();
            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                Console.WriteLine("Nombre Titular del Vehiculo: " + listaVehiculos[i].GetTitular().Nombre);
                Console.WriteLine("Apellido Titular del Vehiculo: " + listaVehiculos[i].GetTitular().Apellido);
                Console.WriteLine("Fecha Nacimiento Titular del Vehiculo: " + listaVehiculos[i].GetTitular().FechaNacimiento);
                Console.WriteLine("Seguro Titular del Vehiculo: " + listaVehiculos[i].GetTitular().Seguro);
                Console.WriteLine("Garaje Titular del Vehiculo: " + listaVehiculos[i].GetTitular().Garaje);
            }
        }
        public static void CrearConductor(List<LicenConducir> listaLinc, List<Conductores> listaPersonas)
        {
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Dia Nacimiento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes Nacimiento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año Nacimiento: ");
            int año = int.Parse(Console.ReadLine());
            string fechaNacimiento = dia + "-" + mes + "-" + año;
            Console.WriteLine("Tipo licencia: ");
            Console.WriteLine("Coche: 1");
            Console.WriteLine("Moto: 2");
            Console.WriteLine("Camion: 3");
            int l = int.Parse(Console.ReadLine());
            LicenConducir encontrado = null;
            for (int i = 0; i < listaLinc.Count; i++)
            {
                if (listaLinc[i].Tipo == l)
                {
                    encontrado = listaLinc[i];
                }
            }
            Conductores co1 = new Conductores(nombre, apellido, fechaNacimiento, encontrado);
            listaPersonas.Add(co1);
            Console.Clear();
        }
        public static void CrearVehiculo(List<Vehiculos> listaVehiculos, int vehiculo)
        {
            // M1-FASE 1
            Console.WriteLine("Introduce la matricula : 4 Numeros/2 Letras");
            string matricula = Console.ReadLine();
            int conNumero;
            int contLetra;
            bool correcto = false;
            string letValidas = "[a-zA-Z]"; // Expresion regular para letras
            Regex exLetras = new Regex(letValidas);
            //------------
            string numValidos = "[0-9]"; // Expresion regular para numeros
            Regex exNumeros = new Regex(numValidos);
            // M1-FASE 2
            while (!correcto)
            {
                conNumero = 0;
                contLetra = 0;
                MatchCollection matchLetras = exLetras.Matches(matricula); // LISTA con cantidad de coincidencias
                MatchCollection matchNum = exNumeros.Matches(matricula); //LISTA con cantidad de coincidencias
                for (int i = 0; i < matchLetras.Count; i++)
                {
                    contLetra++;
                }
                for (int i = 0; i < matchNum.Count; i++)
                {
                    conNumero++;
                }
                if (conNumero == 4)
                {
                    if (contLetra >= 2 && contLetra <= 3)
                    {
                        correcto = true;
                    }
                }
                if (!correcto)
                {
                    Console.WriteLine("Introduce la matricula de nuevo");
                    matricula = Console.ReadLine();
                }
            }
            Console.WriteLine("Introduce la marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduce el color:");
            string color = Console.ReadLine();
            Console.WriteLine("Introduce la marca de las ruedas traseras:");
            string marRueTras = Console.ReadLine();
            Console.WriteLine("Introduce el diametro de las ruedas traseras:");
            double diaRueTras = double.Parse(Console.ReadLine());
            // M1-FASE 2
            Console.WriteLine("Introduce la marca de las ruedas delanteras:");
            string marRueDelan = Console.ReadLine();
            Console.WriteLine("Introduce el diametro de las ruedas delanteras:");
            double diaRueDelan = double.Parse(Console.ReadLine());
            Console.Clear();
            if (vehiculo == 1)
            {
                Coches c1 = new Coches(matricula, marca, color);
                listaVehiculos.Add(c1);
                c1.SetMarcaRuedTra(marRueTras);
                c1.SetDiametroRuedTra(DiametroCorrecto(diaRueTras));
                c1.SetMarcaRuedDel(marRueDelan);
                c1.SetDiametroRuedDel(DiametroCorrecto(diaRueDelan));
                c1.SetDiametroRuedDel(diaRueDelan);
                c1.MostrarDatos();
            }
            if (vehiculo == 2)
            {
                Motos m1 = new Motos(matricula, marca, color);
                listaVehiculos.Add(m1);
                m1.SetMarcaRuedTra(marRueTras);
                m1.SetDiametroRuedTra(DiametroCorrecto(diaRueTras));
                m1.SetMarcaRuedDel(marRueDelan);
                m1.SetDiametroRuedDel(DiametroCorrecto(diaRueDelan));
                m1.SetDiametroRuedDel(diaRueDelan);
                m1.MostrarDatos();
            }
            if (vehiculo == 3)
            {
                Camiones cm1 = new Camiones(matricula, marca, color);
                listaVehiculos.Add(cm1);
                cm1.SetMarcaRuedTra(marRueTras);
                cm1.SetDiametroRuedTra(DiametroCorrecto(diaRueTras));
                cm1.SetMarcaRuedDel(marRueDelan);
                cm1.SetDiametroRuedDel(DiametroCorrecto(diaRueDelan));
                cm1.SetDiametroRuedDel(diaRueDelan);
                cm1.MostrarDatos();
            }
            Console.WriteLine("-----------------");
        }
        public static double DiametroCorrecto(double diamRueda)
        {
            bool diamCorrecto = false;
            double d = diamRueda;
            while (!diamCorrecto)
            {
                if (diamRueda > 0.4 | diamRueda < 4)
                {
                    diamCorrecto = true;
                }
                if (!diamCorrecto)
                {
                    Console.WriteLine("Introduce el diametro de las ruedas delanteras del coche de nuevo:");
                    d = double.Parse(Console.ReadLine());
                }
            }
            return d;
        }
    }
}
