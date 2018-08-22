using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HMapp.Model;

namespace HMapp.DAO
{
    class DaoFuncionarios
    {
        public void Insert(Funcionarios funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Insert into Funcionarios(MATRICULA, RG, NOME, CARGO, COMENTS, SENHA, CNPJ_CLI) values(@MATRICULA, @RG, @NOME, @CARGO, @COMENTS, @SENHA, @CNPJ_CLI)";

            comando.Parameters.AddWithValue("@MATRICULA", funcionario.matricula);
            comando.Parameters.AddWithValue("@RG", funcionario.rg);
            comando.Parameters.AddWithValue("@NOME", funcionario.nome);
            comando.Parameters.AddWithValue("@CARGO", funcionario.cargo);
            comando.Parameters.AddWithValue("@COMENTS", funcionario.coments);
            comando.Parameters.AddWithValue("@SENHA", funcionario.senha);
            comando.Parameters.AddWithValue("@CNPJ_CLI", funcionario.cli.cnpj);


            Conexao.CRUD(comando);
        }

        public void Update(Funcionarios funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Update into Funcionarios(MATRICULA, RG, NOME, CARGO, COMENTS, SENHA, CNPJ_CLI) values(@MATRICULA, @RG, @NOME, @CARGO, @COMENTS, @SENHA, @CNPJ_CLI)";

            comando.Parameters.AddWithValue("@MATRICULA", funcionario.matricula);
            comando.Parameters.AddWithValue("@RG", funcionario.rg);
            comando.Parameters.AddWithValue("@NOME", funcionario.nome);
            comando.Parameters.AddWithValue("@CARGO", funcionario.cargo);
            comando.Parameters.AddWithValue("@COMENTS", funcionario.coments);
            comando.Parameters.AddWithValue("@SENHA", funcionario.senha);
            comando.Parameters.AddWithValue("@CNPJ_CLI", funcionario.cli.cnpj);

            Conexao.CRUD(comando);
        }

        public void Delete(Funcionarios funcionario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Delete from Funcionarios where MATRICULA=@MATRICULA";

            comando.Parameters.AddWithValue("@MATRICULA", funcionario.matricula);

            Conexao.CRUD(comando);
        }

        public Funcionarios BuscarPorMatricula(int matricula)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Funcionarios Where MATRICULA=@MATRICULA";

            comando.Parameters.AddWithValue("@MATRICULA", matricula);

            SqlDataReader dr = Conexao.Selecionar(comando);

            Funcionarios funcionario = new Model.Funcionarios();
            DaoClinicas d_cli = new DaoClinicas();

            if (dr.HasRows)
            {
                dr.Read();
                funcionario.nome = (string)dr["NOME"];
                funcionario.matricula = (int)dr["MATRICULA"];
                funcionario.rg = (int)dr["RG"];
                funcionario.cargo = (string)dr["CARGO"];
                funcionario.coments = (string)dr["COMENTS"];
                funcionario.senha = (string)dr["SENHA"];
                funcionario.cli = d_cli.BuscarPorCNPJ((int)dr["CPNJ_CLI"]);

            }
            else
            {
                funcionario = null;
            }

            return funcionario;
        }

        public IList<Funcionarios> BuscaPorNome(string nome)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Funcionarios where NOME like @NOME";

            comando.Parameters.AddWithValue("@NOME", "%" + nome + "%");

            SqlDataReader dr = Conexao.Selecionar(comando);
            IList<Funcionarios> funcionarios = new List<Funcionarios>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Funcionarios funcionario = new Model.Funcionarios();
                    DaoClinicas d_cli = new DaoClinicas();
                    funcionario.nome = (string)dr["NOME"];
                    funcionario.matricula = (int)dr["MATRICULA"];
                    funcionario.rg = (int)dr["RG"];
                    funcionario.cargo = (string)dr["CARGO"];
                    funcionario.coments = (string)dr["COMENTS"];
                    funcionario.senha = (string)dr["SENHA"];
                    funcionario.cli = d_cli.BuscarPorCNPJ((int)dr["CPNJ_CLI"]);
                    funcionarios.Add(funcionario);
                }
            }
            else
            {
                funcionarios = null;
            }

            return funcionarios;
        }
    }
}
