namespace Projeto_Barbearia_Marques
{
    partial class Listar_func
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditar_func = new System.Windows.Forms.Button();
            this.btnExcluir_func = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 215);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            // 
            // btnEditar_func
            // 
            this.btnEditar_func.Location = new System.Drawing.Point(491, 23);
            this.btnEditar_func.Name = "btnEditar_func";
            this.btnEditar_func.Size = new System.Drawing.Size(80, 60);
            this.btnEditar_func.TabIndex = 1;
            this.btnEditar_func.Text = "EDITAR";
            this.btnEditar_func.UseVisualStyleBackColor = true;
            this.btnEditar_func.Click += new System.EventHandler(this.btnEditar_func_Click);
            // 
            // btnExcluir_func
            // 
            this.btnExcluir_func.Location = new System.Drawing.Point(491, 178);
            this.btnExcluir_func.Name = "btnExcluir_func";
            this.btnExcluir_func.Size = new System.Drawing.Size(80, 60);
            this.btnExcluir_func.TabIndex = 2;
            this.btnExcluir_func.Text = "EXCLUIR";
            this.btnExcluir_func.UseVisualStyleBackColor = true;
            this.btnExcluir_func.Click += new System.EventHandler(this.btnExcluir_func_Click);
            // 
            // Listar_func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 268);
            this.Controls.Add(this.btnExcluir_func);
            this.Controls.Add(this.btnEditar_func);
            this.Controls.Add(this.listView1);
            this.Name = "Listar_func";
            this.Text = "Listar_func";
            this.Load += new System.EventHandler(this.Listar_func_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEditar_func;
        private System.Windows.Forms.Button btnExcluir_func;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}