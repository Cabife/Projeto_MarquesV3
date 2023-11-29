using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Barbearia_Marques
{
    internal class Connection
    {
        private readonly SqlConnection con;
        private readonly string DataBase = "Projeto_MarquesV2";

        public Connection() //Construtor. 
        {
            string stringConnection = @"Data Source=" +
                Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=" +
                DataBase + ";Integrated Security=true";


            con = new SqlConnection(stringConnection); //Instanciar para fazer funcionar a variavel CON.
            con.Open(); //Abrir a conexão com o banco de dados. 
        }

        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }

}
