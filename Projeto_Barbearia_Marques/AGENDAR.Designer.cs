namespace Projeto_Barbearia_Marques
{
    partial class AGENDAR
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chbCcabelo = new System.Windows.Forms.CheckBox();
            this.chbBarba = new System.Windows.Forms.CheckBox();
            this.chbBarbaeCabelo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(3, 9);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(209, 20);
            this.txbFiltro.TabIndex = 1;
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(218, 9);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(48, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "button1";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(209, 72);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chbCcabelo
            // 
            this.chbCcabelo.AutoSize = true;
            this.chbCcabelo.Location = new System.Drawing.Point(3, 113);
            this.chbCcabelo.Name = "chbCcabelo";
            this.chbCcabelo.Size = new System.Drawing.Size(68, 17);
            this.chbCcabelo.TabIndex = 4;
            this.chbCcabelo.Text = "CABELO";
            this.chbCcabelo.UseVisualStyleBackColor = true;
            this.chbCcabelo.CheckedChanged += new System.EventHandler(this.chbCcabelo_CheckedChanged);
            // 
            // chbBarba
            // 
            this.chbBarba.AutoSize = true;
            this.chbBarba.Location = new System.Drawing.Point(3, 136);
            this.chbBarba.Name = "chbBarba";
            this.chbBarba.Size = new System.Drawing.Size(62, 17);
            this.chbBarba.TabIndex = 5;
            this.chbBarba.Text = "BARBA";
            this.chbBarba.UseVisualStyleBackColor = true;
            // 
            // chbBarbaeCabelo
            // 
            this.chbBarbaeCabelo.AutoSize = true;
            this.chbBarbaeCabelo.Location = new System.Drawing.Point(3, 159);
            this.chbBarbaeCabelo.Name = "chbBarbaeCabelo";
            this.chbBarbaeCabelo.Size = new System.Drawing.Size(117, 17);
            this.chbBarbaeCabelo.TabIndex = 6;
            this.chbBarbaeCabelo.Text = "BARBA E CABELO";
            this.chbBarbaeCabelo.UseVisualStyleBackColor = true;
            this.chbBarbaeCabelo.CheckedChanged += new System.EventHandler(this.chbBarbaeCabelo_CheckedChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(92, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txbFiltro);
            this.panel1.Controls.Add(this.chbBarbaeCabelo);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.chbBarba);
            this.panel1.Controls.Add(this.chbCcabelo);
            this.panel1.Location = new System.Drawing.Point(12, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 230);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // AGENDAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "AGENDAR";
            this.Text = "AGENDAR";
            this.Load += new System.EventHandler(this.AGENDAR_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox chbCcabelo;
        private System.Windows.Forms.CheckBox chbBarba;
        private System.Windows.Forms.CheckBox chbBarbaeCabelo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
    }
}