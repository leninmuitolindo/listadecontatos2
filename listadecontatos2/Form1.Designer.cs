namespace listadecontatos2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListadeContatos = new System.Windows.Forms.ListBox();
            this.TextBoxSobrenome = new System.Windows.Forms.TextBox();
            this.TextBoxTelefone = new System.Windows.Forms.TextBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.Incluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // ListadeContatos
            // 
            this.ListadeContatos.FormattingEnabled = true;
            this.ListadeContatos.Location = new System.Drawing.Point(308, 33);
            this.ListadeContatos.Name = "ListadeContatos";
            this.ListadeContatos.Size = new System.Drawing.Size(299, 290);
            this.ListadeContatos.TabIndex = 3;
            this.ListadeContatos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TextBoxSobrenome
            // 
            this.TextBoxSobrenome.Location = new System.Drawing.Point(101, 105);
            this.TextBoxSobrenome.Name = "TextBoxSobrenome";
            this.TextBoxSobrenome.Size = new System.Drawing.Size(144, 20);
            this.TextBoxSobrenome.TabIndex = 4;
            this.TextBoxSobrenome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxTelefone
            // 
            this.TextBoxTelefone.Location = new System.Drawing.Point(101, 166);
            this.TextBoxTelefone.Name = "TextBoxTelefone";
            this.TextBoxTelefone.Size = new System.Drawing.Size(144, 20);
            this.TextBoxTelefone.TabIndex = 5;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(101, 33);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(144, 20);
            this.TextBoxNome.TabIndex = 6;
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(26, 222);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(219, 98);
            this.Incluir.TabIndex = 7;
            this.Incluir.Text = "Incluir contato";
            this.Incluir.UseVisualStyleBackColor = true;
            this.Incluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 358);
            this.Controls.Add(this.Incluir);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.TextBoxTelefone);
            this.Controls.Add(this.TextBoxSobrenome);
            this.Controls.Add(this.ListadeContatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista de Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListadeContatos;
        private System.Windows.Forms.TextBox TextBoxSobrenome;
        private System.Windows.Forms.TextBox TextBoxTelefone;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Button Incluir;
    }
}

