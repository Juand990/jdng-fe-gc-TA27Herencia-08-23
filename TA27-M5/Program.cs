using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TA27_M5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jefe jefe1 = null;
            Manager mang1 = null;
            Senior sn1 = null;
            Mid mid1 = null;
            Junior jun1 = null;
            List<Empleado> list = new List<Empleado>();    
            Console.WriteLine("Introduce Nombre del empleado:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce Apellido del empleado:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Introduce Sueldo del empleado:");
            double sueldo = double.Parse(Console.ReadLine());

            if (sueldo > 8000)
            {
                //IRPF 32%
                sueldo = sueldo - (sueldo * 0.32);
                jefe1 = new Jefe(nombre, apellido, sueldo);
                list.Add(jefe1);
            }
            else
            {
                if (sueldo > 3000 && sueldo < 5000)
                {
                    //IRPF 26%
                    sueldo = sueldo - (sueldo * 0.26);
                    mang1 = new Manager(nombre, apellido, sueldo);
                    list.Add(mang1);
                }
                else
                {
                    if (sueldo > 2700 && sueldo < 4000)
                    {
                        //IRPF 24%
                        sueldo = sueldo - (sueldo * 0.24);
                        sn1 = new Senior(nombre, apellido, sueldo);
                        list.Add(sn1);
                    }
                    else
                    {
                        if (sueldo > 1800 && sueldo < 2500)
                        {
                            //IRPF 15%
                            sueldo = sueldo - (sueldo * 0.15);
                            mid1 = new Mid(nombre, apellido, sueldo);
                            list.Add(mid1);
                        }
                        else
                        {
                            if (sueldo > 900 && sueldo < 1600)
                            {
                                //IRPF 2%
                                sueldo = sueldo - (sueldo * 0.02);
                                jun1 = new Junior(nombre, apellido, sueldo);
                                list.Add(jun1);
                            }
                            else
                            {
                                if (sueldo == 0)
                                {
                                    Voluntario vol1 = new Voluntario(nombre, apellido, sueldo);
                                    Console.WriteLine("Recibe ayuda??");
                                    Console.WriteLine("SI: 1");
                                    Console.WriteLine("No: 2");
                                    int ayuda = int.Parse(Console.ReadLine());
                                    if (ayuda == 1)
                                    {
                                        vol1.Sueldo = 300;
                                    }
                                    Console.WriteLine("Salario con ayudas: "+vol1.Sueldo);
                                }
                            }
                        }
                    }
                }
            }

            BonusPlantilla(list);            
            Console.ReadKey();
        }

        private static void BonusPlantilla(List<Empleado> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Sueldo= list[i].Sueldo+1.1;
                Console.WriteLine(list[i].GetType().Name+": "+  list[i].Sueldo);
            }
        }
    }

}
