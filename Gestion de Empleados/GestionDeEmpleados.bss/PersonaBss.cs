using GestionDeEmpleados.Dal;
using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.bss
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonaDal();
        }

        public void InsertarPersonaBSS(Persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }
    }
}
