using ObraSocialNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.ADO
{
    public class MedicoADO
    {
        private static String connectionString = Configuracion.STRING_DE_CONEXION_MARTIN;
       
        public static void altaMedico(Medico medico, Cuenta cuenta) { 
            SqlConnection conn = new SqlConnection(connectionString);
            int id_cuenta = 0, id_especialidad = 0;
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            String insertarCuenta = "INSERT INTO CUENTA VALUES('" + cuenta.Banco + "', '" + cuenta.Numero + "')";
            SqlCommand cmd = new SqlCommand(insertarCuenta, conn);
            try { 
                cmd.ExecuteNonQuery();
            }catch(SqlException e)
            {
                Console.WriteLine(e);
            }

            cmd.CommandText = "SELECT * FROM CUENTA WHERE CUENTA.numero = " + cuenta.Numero;

            SqlDataReader read = cmd.ExecuteReader();
            try
            {   
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if( String.ReferenceEquals(read.GetSqlValue(1), cuenta.Banco) && Int32.Parse(read.GetSqlValue(2).ToString()) == cuenta.Numero)
                        {
                            id_cuenta = Int32.Parse(read.GetSqlValue(0).ToString());
                        }
                    }
                }
                read.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
                

            cmd.CommandText = "SELECT * FROM ESPECIALIDAD";

            read = cmd.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if(String.ReferenceEquals(read.GetSqlValue(1), medico.Especialidad)){
                            id_especialidad = Int32.Parse(read.GetSqlValue(0).ToString());
                        }
                    }
                }
                read.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            cmd.CommandText = "INSERT INTO MEDICO (nombre, dni, direccion, id_especialidad, id_cuenta) VALUES (@nombre, @dni, @direccion, @id_especialidad, @id_cuenta)";
            cmd.Parameters.AddWithValue("@nombre", medico.Nombre + medico.Apellido);
            cmd.Parameters.AddWithValue("@dni", medico.Dni);
            cmd.Parameters.AddWithValue("@direccion", medico.Direccion);
            cmd.Parameters.AddWithValue("@id_especialidad", id_especialidad);
            cmd.Parameters.AddWithValue("@id_cuenta", id_cuenta);

            try
            {
                cmd.ExecuteNonQuery();
            }catch(SqlException e)
            {
                Console.WriteLine(e);
            }
            conn.Close();
        }
    }
}
