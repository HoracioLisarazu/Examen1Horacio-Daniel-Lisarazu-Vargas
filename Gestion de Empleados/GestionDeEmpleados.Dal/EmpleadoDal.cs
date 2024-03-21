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
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadosDal()
        {
            string consulta = "select * from empleado";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarEmpleadoDAL(Empleado e)
        {
            string consulta = "insert into empleado values('" + e.Nombre + "'," +
                                                          "'" + e.Apellido + "'," +
                                                          "'" + e.Puesto + "'," +
                                                          "'" + e.Salario + "'," +
                                                          "'" + e.FechaDeContratacion + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Empleado ObtenerEmpleadoId(int id)
        {
            String consulta = "select * from empleado where idempleado=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "sadfas");
            Empleado empleado = new Empleado();
            if (tabla.Rows.Count > 0)
            {
                empleado.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                empleado.Nombre = tabla.Rows[0]["nombre"].ToString();
                empleado.Apellido = tabla.Rows[0]["apellido"].ToString();
                empleado.Puesto = tabla.Rows[0]["puesto"].ToString();
                empleado.Salario = Convert.ToDecimal(tabla.Rows[0]["salario"]);
                empleado.FechaDeContratacion = Convert.ToDateTime(tabla.Rows[0]["fechadecontratacion"]);

            }
            return empleado;
        }
        public void EditarEmpleadoDal(Empleado e)
        {
            string consulta = "update empleado set nombre= '" + e.Nombre + "'," +
                                                  "pellido='" + e.Apellido + "'," +
                                                  "puesto='" + e.Puesto + "'," +
                                                  "salario='" + e.Salario + "'," +
                                                  "fechadecontratacion='" + e.FechaDeContratacion + "'," +
                                    "where idempleado=" + e.IdEmpleado;

            conexion.Ejecutar(consulta);



        }
        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from empleado where idempleado=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
