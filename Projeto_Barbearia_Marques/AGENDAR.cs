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
    public partial class AGENDAR : Form
    {
        private DateTime dataSelecionada;
        public AGENDAR()
        {
            InitializeComponent();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void AGENDAR_Load(object sender, EventArgs e)
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




                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(nome);
                    listView1.Items.Add(lv);


                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


            private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
             dataSelecionada = monthCalendar1.SelectionEnd;

            panel1.Visible = true;
            
              
                
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void chbCcabelo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbBarbaeCabelo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
