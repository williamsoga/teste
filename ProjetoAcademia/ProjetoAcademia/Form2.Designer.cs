namespace ProjetoAcademia
{
    partial class Form2
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
            lblnome = new Label();
            txtnome = new TextBox();
            label1 = new Label();
            txtendereco = new TextBox();
            lbltelefone = new Label();
            txttelefone = new TextBox();
            btncadastrar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Perpetua", 15.75F, FontStyle.Bold);
            lblnome.Location = new Point(96, 55);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(61, 24);
            lblnome.TabIndex = 0;
            lblnome.Text = "Nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(95, 93);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(208, 23);
            txtnome.TabIndex = 1;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 15.75F, FontStyle.Bold);
            label1.Location = new Point(505, 46);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 2;
            label1.Text = "endereço";
            // 
            // txtendereco
            // 
            txtendereco.Location = new Point(372, 93);
            txtendereco.Name = "txtendereco";
            txtendereco.Size = new Size(353, 23);
            txtendereco.TabIndex = 3;
            txtendereco.TextChanged += lblendereco_TextChanged;
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Font = new Font("Perpetua", 15.75F, FontStyle.Bold);
            lbltelefone.Location = new Point(94, 148);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(83, 24);
            lbltelefone.TabIndex = 4;
            lbltelefone.Text = "telefone";
            lbltelefone.Click += lbltelefone_Click;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(95, 187);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(232, 23);
            txttelefone.TabIndex = 5;
            txttelefone.TextChanged += lblntelefone_TextChanged;
            // 
            // btncadastrar
            // 
            btncadastrar.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btncadastrar.ForeColor = Color.FromArgb(0, 0, 192);
            btncadastrar.Location = new Point(47, 382);
            btncadastrar.Name = "btncadastrar";
            btncadastrar.Size = new Size(213, 33);
            btncadastrar.TabIndex = 6;
            btncadastrar.Text = "cadastrar";
            btncadastrar.UseVisualStyleBackColor = true;
            btncadastrar.Click += button1_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btnvoltar.ForeColor = Color.FromArgb(0, 0, 192);
            btnvoltar.Location = new Point(466, 388);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(225, 35);
            btnvoltar.TabIndex = 7;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnvoltar);
            Controls.Add(btncadastrar);
            Controls.Add(txttelefone);
            Controls.Add(lbltelefone);
            Controls.Add(txtendereco);
            Controls.Add(label1);
            Controls.Add(txtnome);
            Controls.Add(lblnome);
            Name = "Form2";
            Text = "Form2";
            Load += lblendereço_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnome;
        private TextBox txtnome;
        private Label label1;
        private TextBox txtendereco;
        private Label lbltelefone;
        private TextBox txttelefone;
        private Button btncadastrar;
        private Button btnvoltar;
    }
}