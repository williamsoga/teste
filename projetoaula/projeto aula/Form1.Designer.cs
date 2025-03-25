namespace projeto_aula
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(264, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.lblTitulo.Size = new System.Drawing.Size(203, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "titulo do programa";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(638, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 46);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "sair";
            this.btnSair.UseMnemonic = false;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "txtbox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(34, 68);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "janela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox textBox1;
    }
}

