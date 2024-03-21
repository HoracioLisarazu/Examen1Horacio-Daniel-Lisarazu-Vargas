using GestionDeEmpleados.bss;
using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeEmpleados.Vista.EmpleadoVista
{
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado empleado = new Empleado();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            empleado = bss.ObtenerIdBss(idx);
            textBox1.Text = empleado.Nombre;
            textBox2.Text = empleado.Apellido;
            textBox3.Text = empleado.Puesto;
        }
    }
}
