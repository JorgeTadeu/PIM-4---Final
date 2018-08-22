using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HMapp.Model;

namespace HMapp.DAO
{
    public class DaoPacientes
    {
        public void Insert(Pacientes paciente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Insert into Pacientes(CPF, RG, NOME, SANGUE, SEXO, COMENTS, SENHA) values(@CPF, @RG, @NOME, @SANGUE, @SEXO, @DIABETES, @AIDS, @COMENTS, @SENHA)";

            comando.Parameters.AddWithValue("@CPF", paciente.cpf);
            comando.Parameters.AddWithValue("@RG", paciente.rg);
            comando.Parameters.AddWithValue("@NOME", paciente.nome);
            comando.Parameters.AddWithValue("@SANGUE", paciente.sangue);
            comando.Parameters.AddWithValue("@SEXO", paciente.sexo);
            comando.Parameters.AddWithValue("@COMENTS", paciente.coments);
            comando.Parameters.AddWithValue("@SENHA", paciente.senha);


            Conexao.CRUD(comando);
        }

        public void Update(Pacientes paciente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Update into Pacientes(CPF, RG, NOME, SANGUE, SEXO, COMENTS, SENHA) values(@CPF, @RG, @NOME, @SANGUE, @SEXO, @DIABETES, @AIDS, @COMENTS, @SENHA)";

            comando.Parameters.AddWithValue("@CPF", paciente.cpf);
            comando.Parameters.AddWithValue("@RG", paciente.rg);
            comando.Parameters.AddWithValue("@NOME", paciente.nome);
            comando.Parameters.AddWithValue("@SANGUE", paciente.sangue);
            comando.Parameters.AddWithValue("@SEXO", paciente.sexo);
            comando.Parameters.AddWithValue("@COMENTS", paciente.coments);
            comando.Parameters.AddWithValue("@SENHA", paciente.senha);

            Conexao.CRUD(comando);
        }

        public void Delete(Pacientes paciente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Delete from Pacientes where CPF=@CPF";

            comando.Parameters.AddWithValue("@CPF", paciente.cpf);

            Conexao.CRUD(comando);
        }

        public Pacientes BuscarPorCPF(int cpf)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Pacientes Where CPF=@CPF";

            comando.Parameters.AddWithValue("@CPF", cpf);

            SqlDataReader dr = Conexao.Selecionar(comando);

            Pacientes paciente = new Model.Pacientes();

            if (dr.HasRows)
            {
                dr.Read();
                paciente.nome = (string)dr["NOME"];
                paciente.cpf = (int)dr["CPF"];
                paciente.rg = (int)dr["RG"];
                paciente.sangue = (char)dr["SANGUE"];
                paciente.sexo = (char)dr["SEXO"];
                paciente.coments = (string)dr["COMENTS"];
                paciente.senha = (string)dr["SENHA"];

            }
            else
            {
                paciente = null;
            }

            return paciente;
        }

        public IList<Pacientes> BuscaPorNome(string nome)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Pacientes where NOME like @NOME";

            comando.Parameters.AddWithValue("@NOME", "%" + nome + "%");

            SqlDataReader dr = Conexao.Selecionar(comando);
            IList<Pacientes> pacientes = new List<Pacientes>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pacientes paciente = new Model.Pacientes();
                    paciente.nome = (string)dr["NOME"];
                    paciente.cpf = (int)dr["CPF"];
                    paciente.rg = (int)dr["RG"];
                    paciente.sangue = (char)dr["SANGUE"];
                    paciente.sexo = (char)dr["SEXO"];
                    paciente.coments = (string)dr["COMENTS"];
                    paciente.senha = (string)dr["SENHA"];
                    pacientes.Add(paciente);
                }
            }
            else
            {
                pacientes = null;
            }

            return pacientes;
        }

        public DataTable dt_pac(int cpf)
        {
            string comando = "Select NOME,CPF,RG,SANGUE,SEXO,COMENTS from Pacientes Where CPF=@" + cpf;
            SqlDataAdapter sda = new SqlDataAdapter(comando, Conexao.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
