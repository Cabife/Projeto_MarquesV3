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

namespace Projeto_Barbearia_Marques
{
    public partial class sCadastrar_func : Form
    {
        public sCadastrar_func()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sCadastrar_func_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_func_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO FUNCIONARIOS VALUES 
            (1, @nome_funcionario, @telefone_funcionario, @usuario, @senha)"
            ;

            sqlCommand.Parameters.AddWithValue("@nome_funcionario", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@telefone_funcionario", txbTelefone.Text);
            sqlCommand.Parameters.AddWithValue("@usuario", txbUsuario.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbSenha.Text);

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
