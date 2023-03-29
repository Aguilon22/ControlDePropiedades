using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePropiedades
{
    internal class Propiedades
    {
        int numeroDeCasa;
        double cuotaMantenimiento;
        int dpi;

        public int NumeroDeCasa { get => numeroDeCasa; set => numeroDeCasa = value; }
        public int Dpi { get => dpi; set => dpi = value; }
        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }
    }
}
