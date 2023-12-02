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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
           // ltwNotification.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "select * from Aviso";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string aviso = (string)dr["Aviso"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(aviso);

                    //ltwNotification.Items.Add(lv);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar Customers = new cadastrar();
            Customers.ShowDialog();
        }
    }
}
