using GestionDeEmpleados.DAL;
using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.Dal
{
    public class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from persona";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarPersonaDal(Persona p)
        {
            string consulta = "INSERT INTO PERSONA   VALUES (" + p.IdPersona + " , " +
                                                            " '" + p.Nombre + "' , " +
                                                            " '" + p.Apellido + "' , " + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
