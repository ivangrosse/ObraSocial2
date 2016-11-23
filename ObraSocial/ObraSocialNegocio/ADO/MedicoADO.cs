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
            int id_cuenta = 1, id_especialidad = 1, bandera = 1;

            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                throw new Exception("error en abrir conexion: " + e.Message);
            }

            SqlCommand cmd = new SqlCommand("", conn);
            cmd.CommandText = "SELECT * FROM CUENTA";
            SqlDataReader read = cmd.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if (read.GetSqlValue(1).ToString().Equals(cuenta.Banco) && Int32.Parse(read.GetSqlValue(2).ToString()) == cuenta.Numero)
                        {
                            bandera = 0;
                            break;
                        }
                        
                    }
                }
                read.Close();
            }
            catch (Exception e)
            {
                throw new Exception("error en abrir conexion: " + e.Message);
            }
            if(bandera == 1) { 
                String insertarCuenta = "INSERT INTO CUENTA VALUES('" + cuenta.Banco + "', " + cuenta.Numero + ")";
                cmd.CommandText = insertarCuenta;
            }

            try { 
                cmd.ExecuteNonQuery();
            }catch(SqlException e)
            {
                throw new Exception("error en abrir conexion: " + e.Message);
            }
            conn.Close();
            conn.Open();

            cmd.CommandText = "SELECT * FROM CUENTA";

            read = cmd.ExecuteReader();
            try
            {   
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if( read.GetSqlValue(1).ToString().Equals(cuenta.Banco) && Int32.Parse(read.GetSqlValue(2).ToString()) == cuenta.Numero)
                        {
                            id_cuenta = Int32.Parse(read.GetSqlValue(0).ToString());
                        }
                    }
                }
                read.Close();
            }
            catch(Exception e)
            {
                throw new Exception("error en abrir conexion: " + e.Message);
            }
                

            cmd.CommandText = "SELECT * FROM ESPECIALIDAD";

            read = cmd.ExecuteReader();
            try
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        if(read.GetSqlValue(1).ToString().Equals(medico.Especialidad.Descripcion)){
                            id_especialidad = Int32.Parse(read.GetSqlValue(0).ToString());
                        }
                    }
                }
                read.Close();
            }
            catch(Exception e)
            {
                throw new Exception("error en abrir conexion: " + e.Message);
            }


            String query = "INSERT INTO MEDICO(nombre, dni, direccion, id_especialidad, id_cuenta) VALUES ('" + medico.Nombre + " " + medico.Apellido + "', " + medico.Dni + ", '" + medico.Direccion + "', " + id_especialidad + "," + id_cuenta + ")";
            cmd.CommandText = query;
            

            try
            {
                cmd.ExecuteNonQuery();
            }catch(SqlException e)
            {
                throw new Exception("error en abrir conexion: " + e.Message + cmd.CommandText);
            }
            conn.Close();
        }
        
    }
}
