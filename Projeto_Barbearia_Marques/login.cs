using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Barbearia_Marques
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string userName = txbLogin.Text;
            string userPassword = txbSenha.Text;

            if (userName == "cabife" & userPassword == "123")
            {

                MessageBox.Show("Login bem-sucedido!");
                this.Visible = false;
                //instanciar a tela MENU
                menu smenu =new menu();
                smenu.ShowDialog();
                //esconder a tela atual
                
                //mostrar a tela menu
               

            }
            else
            {
                MessageBox.Show("Falha no login. Verifique seu nome de usuário e senha.");
            }
        }
    }
}
