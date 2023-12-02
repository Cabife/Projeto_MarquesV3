using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Barbearia_Marques
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sCadastrar Scadastrar = new sCadastrar();
            Scadastrar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listar sListar = new listar();
            sListar.ShowDialog();
            
        }

        private void customers_Load(object sender, EventArgs e)
        {

        }
    }

   
}
