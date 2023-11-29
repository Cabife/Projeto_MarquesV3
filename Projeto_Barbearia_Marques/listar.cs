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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Barbearia_Marques
{
    public partial class listar : Form
    {
        public listar()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listar_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {

            listView1.Items.Clear();
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "select * from CLIENTES";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string nome = (string)dr["nome_cliente"];
                    string telefone = (string)dr["telefone_cliente"];
                    string email = (string)dr["email_cliente"];



                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(email);
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
    }

}
