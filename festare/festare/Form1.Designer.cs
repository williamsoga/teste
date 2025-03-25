namespace festare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBoasVindas = new Label();
            lblInformacao = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEndereco = new Label();
            txtRua = new TextBox();
            txtNumeroRua = new TextBox();
            txtBairro = new TextBox();
            btnCadastro = new Button();
            btnSair = new Button();
            cboEstado = new ComboBox();
            SuspendLayout();
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.BackColor = SystemColors.ActiveCaption;
            lblBoasVindas.Font = new Font("PanRoman", 20F, FontStyle.Bold);
            lblBoasVindas.Location = new Point(258, 9);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Padding = new Padding(30, 20, 30, 20);
            lblBoasVindas.Size = new Size(210, 68);
            lblBoasVindas.TabIndex = 0;
            lblBoasVindas.Text = "Boas vindas";
            lblBoasVindas.Click += lblBoasVindas_Click;
            // 
            // lblInformacao
            // 
            lblInformacao.AutoSize = true;
            lblInformacao.Font = new Font("Segoe UI", 15F);
            lblInformacao.Location = new Point(106, 87);
            lblInformacao.Name = "lblInformacao";
            lblInformacao.Size = new Size(512, 28);
            lblInformacao.TabIndex = 1;
            lblInformacao.Text = "por favor insira seus dados para contratar nossos serviços";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(12, 143);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(120, 21);
            lblNome.TabIndex = 2;
            lblNome.Text = "insira seu nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(172, 145);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "nome completo";
            txtNome.Size = new Size(420, 23);
            txtNome.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(12, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(172, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(316, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F);
            lblTelefone.Location = new Point(12, 236);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(67, 21);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            lblTelefone.Click += lblTelefone_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(172, 238);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone";
            txtTelefone.Size = new Size(232, 23);
            txtTelefone.TabIndex = 7;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F);
            lblEndereco.Location = new Point(12, 283);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 21);
            lblEndereco.TabIndex = 8;
            lblEndereco.Text = "Endereço";
            lblEndereco.Click += lblEndereco_Click;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(172, 285);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Nome da rua";
            txtRua.Size = new Size(184, 23);
            txtRua.TabIndex = 9;
            // 
            // txtNumeroRua
            // 
            txtNumeroRua.Location = new Point(388, 285);
            txtNumeroRua.Name = "txtNumeroRua";
            txtNumeroRua.PlaceholderText = "Numero da rua ";
            txtNumeroRua.Size = new Size(100, 23);
            txtNumeroRua.TabIndex = 10;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(518, 285);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "bairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 11;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 15F);
            btnCadastro.Location = new Point(3, 393);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(129, 45);
            btnCadastro.TabIndex = 12;
            btnCadastro.Text = "cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 15F);
            btnSair.Location = new Point(674, 393);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 45);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(674, 285);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 14;
            cboEstado.Text = "escolha seu estado";
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 450);
            Controls.Add(cboEstado);
            Controls.Add(btnSair);
            Controls.Add(btnCadastro);
            Controls.Add(txtBairro);
            Controls.Add(txtNumeroRua);
            Controls.Add(txtRua);
            Controls.Add(lblEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblInformacao);
            Controls.Add(lblBoasVindas);
            Name = "Form1";
            Text = "festare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBoasVindas;
        private Label lblInformacao;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblEndereco;
        private TextBox txtRua;
        private TextBox txtNumeroRua;
        private TextBox txtBairro;
        private Button btnCadastro;
        private Button btnSair;
        private ComboBox cboEstado;
    }
}
