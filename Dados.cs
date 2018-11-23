using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


public class Dados
{
    SqlConnection con;

    public Dados()
    {
        con = new SqlConnection(
        new SqlConnectionStringBuilder()
        {
            DataSource = "regulus.cotuca.unicamp.br",
            InitialCatalog = "PR118195",
            UserID = "PR118195",
            Password = "PR118195"
        }.ConnectionString
        );
    }

    public void MudarDados(string nome, int fase)
    {

        string sql = $"update Usuario set fase = {fase} where nome = '{nome}'";

        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        con.Open();
        try
        {
            int i = cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {

        }
        finally
        {
            con.Close();
        }
    }
}

