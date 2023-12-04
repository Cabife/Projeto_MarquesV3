namespace Projeto_Barbearia_Marques
{
    partial class sCadastrar_func
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.btnCadastrar_func = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(83, 47);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(204, 20);
            this.txbNome.TabIndex = 4;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(83, 128);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(204, 20);
            this.txbTelefone.TabIndex = 5;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(83, 208);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(204, 20);
            this.txbUsuario.TabIndex = 6;
            // 
            // btnCadastrar_func
            // 
            this.btnCadastrar_func.Location = new System.Drawing.Point(95, 319);
            this.btnCadastrar_func.Name = "btnCadastrar_func";
            this.btnCadastrar_func.Size = new System.Drawing.Size(92, 23);
            this.btnCadastrar_func.TabIndex = 8;
            this.btnCadastrar_func.Text = "CADASTRAR";
            this.btnCadastrar_func.UseVisualStyleBackColor = true;
            this.btnCadastrar_func.Click += new System.EventHandler(this.btnCadastrar_func_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(83, 266);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(204, 20);
            this.txbSenha.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Senha";
            // 
            // sCadastrar_func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.btnCadastrar_func);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sCadastrar_func";
            this.Text = "sCadastrar_func";
            this.Load += new System.EventHandler(this.sCadastrar_func_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Button btnCadastrar_func;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label4;
    }
}