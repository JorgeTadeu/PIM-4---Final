using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HMapp.Model;


namespace HMapp.DAO
{
    class DaoClinicas
    {
        public void Insert(Clinicas clinica)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Insert into Clinicas(CNPJ, NOME) values(@CNPJ, @NOME)";

            comando.Parameters.AddWithValue("@CNPJ", clinica.cnpj);
            comando.Parameters.AddWithValue("@NOME", clinica.nome);


            Conexao.CRUD(comando);
        }

        public void Update(Clinicas clinica)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Update into Clinicas(CNPJ, NOME) values(@CNPJ, @NOME)";

            comando.Parameters.AddWithValue("@CNPJ", clinica.cnpj);
            comando.Parameters.AddWithValue("@NOME", clinica.nome);

            Conexao.CRUD(comando);
        }

        public void Delete(Clinicas clinica)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Delete from Clinicas where CNPJ=@CNPJ";

            comando.Parameters.AddWithValue("@CPF", clinica.cnpj);

            Conexao.CRUD(comando);
        }

        public Clinicas BuscarPorCNPJ(int cnpj)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Clinicas Where CNPJ=@CNPJ";

            comando.Parameters.AddWithValue("@CNPJ", cnpj);

            SqlDataReader dr = Conexao.Selecionar(comando);

            Clinicas clinicas = new Model.Clinicas();

            if (dr.HasRows)
            {
                dr.Read();
                clinicas.nome = (string)dr["NOME"];
                clinicas.cnpj = (int)dr["CNPJ"];


            }
            else
            {
                clinicas = null;
            }

            return clinicas;
        }

        public IList<Clinicas> BuscaPorNome(string nome)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Clinicas where NOME like @NOME";

            comando.Parameters.AddWithValue("@NOME", "%" + nome + "%");

            SqlDataReader dr = Conexao.Selecionar(comando);
            IList<Clinicas> clinicas = new List<Clinicas>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Clinicas clinica = new Model.Clinicas();
                    clinica.nome = (string)dr["NOME"];
                    clinica.cnpj = (int)dr["CNPJ"];
                }
            }
            else
            {
                clinicas = null;
            }

            return clinicas;
        }
    }
}
