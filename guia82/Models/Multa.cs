

using guia82.Models.Exportadores;
using System.Reflection.Metadata.Ecma335;

namespace guia82.Models
{
    public class Multa : IComparable ,IExportable
    {
        public string Patente { get; set; }
        public DateOnly Vencimiento { get; set; }
        public double  Importe { get; set; }

        public Multa() { }
        public Multa(string p,DateOnly ven,double imp)
        {
            this.Patente = p;
            this.Vencimiento = ven;
            this.Importe = imp;
        }

        public int CompareTo(object other)
        {
            Multa? obj = other as Multa;
            if (obj != null)
            {
              return Patente.CompareTo(obj.Patente);
            }
            return -1;
        }
        public override string ToString()
        {
            return $@" {Patente} - {Vencimiento} - {Importe}";
        }
        public bool Importar(string data, IExportador exp)
        {
            return exp.Importar(data, this);
        }

        public string Exportar(IExportador exp)
        {
            return exp.Exportar(this); //Con el this le pasas la reerncia actual de multa.
        }
    }
}
