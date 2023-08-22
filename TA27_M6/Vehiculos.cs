using System.Collections.Generic;

namespace TA27_M6
{
    internal abstract class Vehiculos
    {
        private string matricula;
        private string marca;
        private string color;
        private string marcaRuedasT;
        private double diametroRuedaT;
        private string marcaRuedasD;
        private double diametroRuedaD;
        private TitularVehs titular; // M3-FASE 1
        private List<Conductores> conductores; // M3-FASE 1

        public Vehiculos(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }
        //GET
        public string GetMatricula()
        {
            return matricula;
        }
        public string GetMarca()
        {
            return marca;
        }
        public string GetColor()
        {
            return color;
        }
        public string GetMarcaRuedTra()
        {
            return marcaRuedasT;
        }
        public double GetDiametroRueTra()
        {
            return diametroRuedaT;
        }
        public string GetMarcaRuedDel()
        {
            return marcaRuedasD;
        }
        public double GetDiametroRuedDel()
        {
            return diametroRuedaD;
        }
        public TitularVehs GetTitular()
        {
            return titular;
        }
        public List<Conductores> GetConductores()
        {
            return conductores;
        }

        //SET
        public void SetMarcaRuedTra(string nMarcaRuedasT)
        {
            this.marcaRuedasT = nMarcaRuedasT;
        }
        public void SetDiametroRuedTra(double nDiametroRuedasT)
        {
            this.diametroRuedaT = nDiametroRuedasT;
        }
        public void SetMarcaRuedDel(string nMarcaRuedasD)
        {
            this.marcaRuedasD = nMarcaRuedasD;
        }
        public void SetDiametroRuedDel(double nDiametroRuedasD)
        {
            this.diametroRuedaD = nDiametroRuedasD;
        }
        public void SetTitular(TitularVehs titular)
        {
            this.titular = titular;
        }
        public void SetConductores(List<Conductores> pers)
        {
            this.conductores = pers;
        }
    }
}