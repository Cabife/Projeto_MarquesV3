using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_Barbearia_Marques
{
    public partial class sCadastrar : Form
    {
        public sCadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO CLIENTES VALUES 
            (1, @nome_cliente, @telefone_cliente, @email_cliente)"
            ;

            sqlCommand.Parameters.AddWithValue("@nome_cliente", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@email_cliente", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@telefone_cliente", txbTelefone.Text);

            try
            {
                //Insere o cliente
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            MessageBox.Show(
                "Cadastrado com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
