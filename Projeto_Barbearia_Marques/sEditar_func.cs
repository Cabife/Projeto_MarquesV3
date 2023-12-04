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
    public partial class sEditar_func : Form
    {
        private int editar;
        public sEditar_func(int Armazenar)
        {
            editar = Armazenar;
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT * FROM  FUNCIONARIO WHERE id = @id";
            sqlCom.Parameters.AddWithValue("@id", editar);
            using (SqlDataReader dr = sqlCom.ExecuteReader())
            {
                if (dr.Read())
                {
                    txbNome.Text = dr["nome_funcionario"].ToString();
                    txbTelefone.Text = dr["telefone_funcionario"].ToString();
                    txbUsuario.Text = dr["usuario"].ToString();
                    txbSenha.Text = dr["senha"].ToString();
                }
            }
        }



        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbTelefone.Clear();
            txbUsuario.Clear();
            txbSenha.Clear();
        }



        private void sEditar_func_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = @"SELECT * FROM  FUNCIONARIOS WHERE id = @id";
            sqlCom.Parameters.AddWithValue("@id", editar);
            using (SqlDataReader dr = sqlCom.ExecuteReader())
            {
                if (dr.Read())
                {
                    txbNome.Text = dr["nome_funcionario"].ToString();
                    txbTelefone.Text = dr["telefone_funcionario"].ToString();
                    txbUsuario.Text = dr["usuario"].ToString();
                    txbSenha.Text = dr["senha"].ToString();

                }
            }
        }

        
    }
}
