using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HMapp.Model;

namespace HMapp.DAO
{
    class DaoMedicos
    {
        public void Insert(Medicos medico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Insert into Medicos(CRM, NOME, ESPEC, COMENTS, SENHA, CNPJ_CLI) values(@CRM, @NOME, @ESPEC, @COMENTS, @SENHA, @CNPJ_CLI)";

            comando.Parameters.AddWithValue("@CRM", medico.crm);
            comando.Parameters.AddWithValue("@NOME", medico.nome);
            comando.Parameters.AddWithValue("@ESPEC", medico.espec);
            comando.Parameters.AddWithValue("@COMENTS", medico.coments);
            comando.Parameters.AddWithValue("@SENHA", medico.senha);
            comando.Parameters.AddWithValue("@CNPJ_CLI", medico.cli.cnpj);


            Conexao.CRUD(comando);
        }

        public void Update(Medicos medico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Update into Medicos(CRM, NOME, ESPEC, COMENTS, SENHA, CNPJ_CLI) values(@CRM, @NOME, @ESPEC, @COMENTS, @SENHA, @CNPJ_CLI)";

            comando.Parameters.AddWithValue("@CRM", medico.crm);
            comando.Parameters.AddWithValue("@NOME", medico.nome);
            comando.Parameters.AddWithValue("@ESPEC", medico.espec);
            comando.Parameters.AddWithValue("@COMENTS", medico.coments);
            comando.Parameters.AddWithValue("@SENHA", medico.senha);
            comando.Parameters.AddWithValue("@CNPJ_CLI", medico.cli.cnpj);

            Conexao.CRUD(comando);
        }

        public void Delete(Medicos medico)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Delete from Medicos where CRM=@CRM";

            comando.Parameters.AddWithValue("@CRM", medico.crm);

            Conexao.CRUD(comando);
        }

        public Medicos BuscarPorCRM(int crm)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Medicos Where CRM=@CRM";

            comando.Parameters.AddWithValue("@CRM", crm);

            SqlDataReader dr = Conexao.Selecionar(comando);

            Medicos medico = new Model.Medicos();

            if (dr.HasRows)
            {
                dr.Read();
                medico.nome = (string)dr["NOME"];
                medico.crm = (int)dr["CPF"];
                medico.espec = (string)dr["ESPEC"];
                medico.coments = (string)dr["COMENTS"];
                medico.senha = (string)dr["SENHA"];
                medico.cli.cnpj = (int)dr["CNPJ_CLI"];

            }
            else
            {
                medico = null;
            }

            return medico;
        }

        public IList<Medicos> BuscaPorNome(string nome)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Medicos where NOME like @NOME";

            comando.Parameters.AddWithValue("@NOME", "%" + nome + "%");

            SqlDataReader dr = Conexao.Selecionar(comando);
            IList<Medicos> medicos = new List<Medicos>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Medicos medico = new Model.Medicos();
                    medico.nome = (string)dr["NOME"];
                    medico.crm = (int)dr["CPF"];
                    medico.espec = (string)dr["ESPEC"];
                    medico.coments = (string)dr["COMENTS"];
                    medico.senha = (string)dr["SENHA"];
                    medico.cli.cnpj = (int)dr["CNPJ_CLI"];
                    medicos.Add(medico);
                }
            }
            else
            {
                medicos = null;
            }

            return medicos;
        }
    }
}
