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
    class DaoConsultas
    {
        public void Insert(Consultas consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Insert into Consultas(ID, HR_INICIO, HR_FIM, COMENTS, CRM_M, CPF_P) values(@ID, @HR_INICIO, @HR_FIM, @COMENTS, @CRM_M, @CPF_P)";

            comando.Parameters.AddWithValue("@ID", consulta.id);
            comando.Parameters.AddWithValue("@HR_INICIO", consulta.hr_inicio);
            comando.Parameters.AddWithValue("@HR_FIM", consulta.hr_fim);
            comando.Parameters.AddWithValue("@COMENTS", consulta.coments);
            comando.Parameters.AddWithValue("@CRM_M", consulta.med.crm);
            comando.Parameters.AddWithValue("@CPF_P", consulta.pac.cpf);


            Conexao.CRUD(comando);
        }

        public void Update(Consultas consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Update into Consultas(ID, HRA_INICIO, HRA_FIM, COMENTS, CRM_M, CPF_P) values(@ID, @HR_INICIO, @HR_FIM, @COMENTS, @CRM_M, @CPF_P)";

            comando.Parameters.AddWithValue("@ID", consulta.id);
            comando.Parameters.AddWithValue("@HRA_INICIO", consulta.hr_inicio);
            comando.Parameters.AddWithValue("@HRA_FIM", consulta.hr_fim);
            comando.Parameters.AddWithValue("@COMENTS", consulta.coments);
            comando.Parameters.AddWithValue("@CRM_M", consulta.med.crm);
            comando.Parameters.AddWithValue("@CPF_P", consulta.pac.cpf);

            Conexao.CRUD(comando);
        }

        public void Delete(Consultas consulta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Delete from Consultas where ID=@ID";

            comando.Parameters.AddWithValue("@ID", consulta.id);

            Conexao.CRUD(comando);
        }

        public Consultas BuscarPorID(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Pacientes Where ID=@ID";

            comando.Parameters.AddWithValue("@ID", id);

            SqlDataReader dr = Conexao.Selecionar(comando);

            Consultas consulta = new Model.Consultas();

            if (dr.HasRows)
            {
                dr.Read();
                consulta.id = (int)dr["ID"];
                consulta.hr_inicio = (DateTime)dr["HRA_INICIO"];
                consulta.hr_fim = (DateTime)dr["FIM"];
                consulta.coments = (string)dr["COMENTS"];
                consulta.med.crm = (int)dr["CRM_M"];
                consulta.pac.cpf = (int)dr["CPF_P"];

            }
            else
            {
                consulta = null;
            }

            return consulta;
        }

        public IList<Consultas> BuscaPorCPF(int cpf)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Consultas where CPF_P=@CPF_P";

            comando.Parameters.AddWithValue("@CPF", cpf);

            SqlDataReader dr = Conexao.Selecionar(comando);
            IList<Consultas> consultas = new List<Consultas>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Consultas consulta = new Model.Consultas();
                    consulta.id = (int)dr["ID"];
                    consulta.hr_inicio = (DateTime)dr["HRA_INICIO"];
                    consulta.hr_fim = (DateTime)dr["FIM"];
                    consulta.coments = (string)dr["COMENTS"];
                    consulta.med.crm = (int)dr["CRM_M"];
                    consulta.pac.cpf = (int)dr["CPF_P"];
                    consultas.Add(consulta);
                }
            }
            else
            {
                consultas = null;
            }

            return consultas;
        }


        public DataTable dt_cons(int cpf)
        {
            string comando = "Select * from Consultas Where CPF_P=@" + cpf;
            SqlDataAdapter sda = new SqlDataAdapter(comando, Conexao.Conectar());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
