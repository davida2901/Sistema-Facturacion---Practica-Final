using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace SistemaFact
{
    class Conexion
    {

        SqlConnection conn = new SqlConnection();



        public Conexion()
        {
            conectar();


        }

        public void conectar()
        {


            conn.ConnectionString = "Data Source = DESKTOP-6VHHMUG\\SQLEXPRESS02; Initial Catalog = SisFacturacion; Integrated Security = True";

            conn.Open();

            Console.WriteLine("Conexion esta:" + conn.State);
            Console.WriteLine(conn.DataSource);
            Console.WriteLine(conn.Database);
            Console.WriteLine(conn.WorkstationId);

        }


        public void desconectar()
        {
            conn.Close();
        }


        public List<String> consultarPermisos(String usuario)
        {
            List<String> permisos = new List<string>();

            String comando = "SELECT IDOPCION FROM V_PERMISOS WHERE USUARIO = @USUARIO";

            SqlCommand cmd = new SqlCommand(comando);

            cmd.Parameters.AddWithValue("@USUARIO", usuario);

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                permisos.Add(reader["IDOPCION"].ToString());

            }
            reader.Close();



            return permisos;
        }











    }
}
