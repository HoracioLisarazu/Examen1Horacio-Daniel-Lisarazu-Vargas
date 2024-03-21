﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Modelos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public Decimal Salario { get; set; }
        public DateTime FechaDeContratacion { get; set; }

    }
}