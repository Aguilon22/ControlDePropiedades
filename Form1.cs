using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePropiedades
{
    public partial class Form1 : Form
    {
        List<Propiedades> propiedadesList = new List<Propiedades>();
        List<Propietarios> propietarioList = new List<Propietarios>();
        List<Reporte>reporteList = new List<Reporte>();
        private void LeerPropiedades()
        {
            FileStream stream = new FileStream("Propiedades.txt",FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Propiedades propiedad = new Propiedades();
                propiedad.NumeroDeCasa = Convert.ToInt32(reader.ReadLine());
                propiedad.CuotaMantenimiento = Convert.ToDouble(reader.ReadLine());
                propiedad.Dpi = Convert.ToInt32(reader.ReadLine());
            }
        }
        private void LeerPropietarios()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Propietarios propietario = new Propietarios();
                propietario.Dpi = Convert.ToInt32(reader.ReadLine());
                propietario.Nombre = reader.ReadLine();
                propietario.Apellido = reader.ReadLine();
                propietarioList.Add(propietario);
            }
            reader.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void mostrarReporte()
        {
            for (int i = 0; i < propiedadesList.Count; i++)
            {
                for (int j = 0; j < propietarioList.Count; j++)
                {
                    if (propiedadesList[i].Dpi == propietarioList[j].Dpi)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre = propietarioList[i].Nombre;
                        reporte.Apellido = propietarioList[i].Apellido;
                        reporte.NumeroDeCasa = propiedadesList[j].NumeroDeCasa;
                        reporte.CuotaMantenimiento = propiedadesList[i].CuotaMantenimiento;
                        reporteList.Add(reporte);
                    }
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporteList;
            dataGridView1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LeerPropiedades();
            LeerPropietarios();
            mostrarReporte();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

    }
}
