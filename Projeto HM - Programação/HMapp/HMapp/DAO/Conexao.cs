using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace HMapp.DAO
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            string stringConexao = "Data Source=DESKTOP-STNDAK9/SQLEXPRESS; Initial Catalog=HMApp; Integrated Security=True;";
            SqlConnection conexao = new SqlConnection(stringConexao);
             conexao.Open();
            return conexao;
        }

        public static void CRUD(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static SqlDataReader Selecionar(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
