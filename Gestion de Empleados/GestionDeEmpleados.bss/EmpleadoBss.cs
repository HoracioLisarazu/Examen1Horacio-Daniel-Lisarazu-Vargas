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
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadosDal();
        }

        public void InsertarEmpeadoBss(Empleado e)
        {
            dal.InsertarEmpleadoDAL(e);
        }
        public Empleado ObtenerIdBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }
        public void EditarEmpleadoBss(Empleado e)
        {
            dal.EditarEmpleadoDal(e);
        }
        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
