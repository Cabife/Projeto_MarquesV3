﻿namespace Projeto_Barbearia_Marques
{
    partial class cadastrar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCadastrar_func = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "CADASTRAR_CLI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(9, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "LISTAR_CLI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadastrar_func
            // 
            this.btnCadastrar_func.Location = new System.Drawing.Point(2, 154);
            this.btnCadastrar_func.Name = "btnCadastrar_func";
            this.btnCadastrar_func.Size = new System.Drawing.Size(305, 65);
            this.btnCadastrar_func.TabIndex = 3;
            this.btnCadastrar_func.Text = "CADASTRAR_FUNC";
            this.btnCadastrar_func.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(2, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(305, 65);
            this.button5.TabIndex = 4;
            this.button5.Text = "LISTAR_DUNC";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 304);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCadastrar_func);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR";
            this.Load += new System.EventHandler(this.customers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCadastrar_func;
        private System.Windows.Forms.Button button5;
    }
}