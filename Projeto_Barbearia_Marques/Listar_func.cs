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
    public partial class Listar_func : Form
    {
        public Listar_func()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void Listar_func_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void UpdateListView()
        {

            listView1.Items.Clear();
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "select * from FUNCIONARIO";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string nome = (string)dr["nome_funcionario"];
                    string telefone = (string)dr["telefone"];
                    string usuario = (string)dr["usuario"];
                    string senha = (string)dr["senha"];



                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(usuario);
                    lv.SubItems.Add(senha);
                    listView1.Items.Add(lv);


                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        private void procura_usuario(object sender, EventArgs e)
        {
            UpdateListView();

        }



        private void btnEditar_func_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvid = listView1.SelectedItems[0];
                string sid = lvid.SubItems[0].Text;
                int Armazena = Convert.ToInt32(sid);

                //instanciar tela de editar funcionario
                sEditar_func Seditarfuncionario = new sEditar_func(Armazena);
                Seditarfuncionario.ShowDialog();

            }

        }

        private void btnExcluir_func_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvid = listView1.SelectedItems[0];
                string sid = lvid.SubItems[0].Text;
                int Armazena = Convert.ToInt32(sid);


                Connection conn = new Connection();
                SqlCommand sqlCom = new SqlCommand();

                sqlCom.Connection = conn.ReturnConnection();
                sqlCom.CommandText = "DELETE from FUNCIONARIOS WHERE id = @id";
                sqlCom.Parameters.AddWithValue("@id", Armazena);

                SqlDataReader dr = sqlCom.ExecuteReader();
            }

        }

      

    }
}
