﻿using System;

namespace TA27_M6
{
    internal class Motos : Vehiculos
    {
        private int ruedas = 2;

        public Motos(string matricula, string marca, string color)
            : base(matricula, marca, color)
        {
        }
        //GET
        public int GetRuedas()
        {
            return ruedas;
        }
        //Mostrar Datos
        public void MostrarDatos()
        {
            Console.WriteLine("Nº de Ruedas: " + this.ruedas);
            Console.WriteLine("Matricula: " + base.GetMatricula());
            Console.WriteLine("Marca: " + base.GetMarca());
            Console.WriteLine("Color: " + base.GetColor());
            Console.WriteLine("Marca Ruedas Tras.: " + base.GetMarcaRuedTra());
            Console.WriteLine("Diametro Rue. Traseras: " + base.GetDiametroRueTra());
            Console.WriteLine("Marca Ruedas Del.: " + base.GetMarcaRuedDel());
            Console.WriteLine("Diametro Ruedas Del: " + base.GetDiametroRuedDel());

        }

    }
}