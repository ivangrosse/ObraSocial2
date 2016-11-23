using ObraSocialNegocio.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObraSocialNegocio.ADO
{
    public class AfiliadoADO
    {
        public static void altaAfiliado(Afiliado afiliado) { 
        String connectionString = Configuracion.STRING_DE_CONEXION_IVAN;
        //String result = "UNSuccessful";
        SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                String query = "INSERT INTO AFILIADO VALUES(" + "'" + afiliado.Dni + "', '" + afiliado.Nombre + "', '" + afiliado.Apellido + "')";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            conn.Close();

        }

        public static Afiliado buscarAfiliado(int nroAfiliado)
        {
            Afiliado a = new Afiliado();
            String connectionString = Configuracion.STRING_DE_CONEXION_IVAN;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("", conn);
                cmd.CommandText = "SELECT * from AFILIADO where numero = " + nroAfiliado;
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        a.Dni = Int32.Parse(read.GetValue(1).ToString());
                        a.Nombre = read.GetSqlValue(2).ToString();
                        a.Apellido = read.GetValue(3).ToString();
                    }
                }


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            conn.Close();
            return a;
        }
    }
}
