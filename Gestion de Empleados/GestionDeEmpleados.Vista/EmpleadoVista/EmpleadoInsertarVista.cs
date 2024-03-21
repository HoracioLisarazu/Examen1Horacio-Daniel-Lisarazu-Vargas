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
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, textBox5);
        }

        private void button1_Click(object sender, EventArgs e, System.Windows.Forms.TextBox textBox)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = textBox1.Text;
            empleado.Apellido = textBox2.Text;
            empleado.Puesto = textBox3.Text;
            empleado.Salario= Convert.ToDecimal(textBox5.Text);
            empleado.FechaDeContratacion = dateTimePicker1.Value;

            bss.InsertarEmpeadoBss(empleado);
            MessageBox.Show("Se guardo correctamente al empleado");



        }
    }
}
