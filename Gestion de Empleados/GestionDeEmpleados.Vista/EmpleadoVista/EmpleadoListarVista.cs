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
    public partial class EmpleadoListarVista : Form
    {
        int idx = 0;
        Empleado empleado = new Empleado();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoListarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            
        }


    }
}
