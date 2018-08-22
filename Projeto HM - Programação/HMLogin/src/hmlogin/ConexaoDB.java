/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hmlogin;
import java.sql.*;

/**
 *
 * @author jt_mu
 */
public class ConexaoDB {
    
    public static void main(String args[]) {

                // Criando as variáveis de conexão e de statement
                Connection con;
                Statement stmt;
                String query = "select crm , senha from Medicos";
                // Verificando se o driver JDBC está instalado e pode ser utilizado
                try
                {
                        Class.forName("com.microsoft.jdbc.sqlserver.SQLServerDriver");

                }
                catch(java.lang.ClassNotFoundException e)
                {
                        System.err.print("ClassNotFoundException: ");
                        System.err.println(e.getMessage());
                }

                try
                {

        // Abrindo a conexão com o servidor 
        con = DriverManager.getConnection("jdbc:microsoft:sqlserver://(local):1433","sa","manager");

                        stmt = con.createStatement();

                        // Criando a instrução a partir do SELECT que está dentro da variável query
                        ResultSet rs = stmt.executeQuery(query);

                        System.out.println("Lista de linhas da tabela Medicos:");

                        // Fazendo um loop para mostrar tudo o que foi retornado do banco
                        while (rs.next())
                        {

                        // Obtendo o campo name em um string
                        String s = rs.getString("crm");
                        // Obtendo o campo id em um inteiro
                        int i = rs.getInt("senha");
                        System.out.println(s + " " + i);
                        }

                        //Fechamdno a instrução e a conexão
                        stmt.close();
                        con.close();
                }
                        catch(SQLException ex)
                {
                        System.err.println("SQLException: " + ex.getMessage());
                }
        }
    
}
