using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePropiedades
{
    internal class Reporte
    {
        string nombre;
        string apellido;
        int numeroDeCasa;
        double cuotaMantenimiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroDeCasa { get => numeroDeCasa; set => numeroDeCasa = value; }
        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
