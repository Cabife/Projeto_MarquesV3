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
    public partial class seditar : Form
    {
        private int editar;
        public seditar(int Armazenar)
        {
            editar = Armazenar;
            InitializeComponent();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE CLIENTE SET
            Nome = @nome_cliente,
            Email = @email_cliente,
            Telefone = @telefone_cliente
            WHERE Id = @Id"
            ;

            sqlCommand.Parameters.AddWithValue("@Name", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", txbTelefone.Text);
            sqlCommand.Parameters.AddWithValue("@Id", editar);

            try
            {
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Atualizado com Sucesso", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception err)
            {
                MessageBox.Show("Erro: Problemas ao editar usuário no banco \n" + err.Message);
            }

            finally
            {
                connection.CloseConnection();
            }
            this.Close();
        }

        private void seditar_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT * FROM  CLIENTES WHERE id = @id";
            sqlCom.Parameters.AddWithValue("@id", editar);
            using (SqlDataReader dr = sqlCom.ExecuteReader())
            {
                if (dr.Read())
                {
                    txbNome.Text = dr["Nome"].ToString();
                    txbEmail.Text = dr["Email"].ToString();
                    txbTelefone.Text = dr["Telefone"].ToString();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbTelefone.Clear();
        }
    }
}
