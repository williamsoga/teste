namespace ProjetoAcademia
{
    partial class Form4
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
            label1 = new Label();
            lblnomeinstrutor = new Label();
            txtnomeinstrutor = new TextBox();
            lbltelefoneinstrutor = new Label();
            txttelefoneinstrutor = new TextBox();
            lblespecialidade = new Label();
            txtespecialidade = new TextBox();
            btncadastroinstrutor = new Button();
            btnpaginainicialinstrutor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Instrutor";
            label1.Click += label1_Click;
            // 
            // lblnomeinstrutor
            // 
            lblnomeinstrutor.AutoSize = true;
            lblnomeinstrutor.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnomeinstrutor.Location = new Point(13, 71);
            lblnomeinstrutor.Name = "lblnomeinstrutor";
            lblnomeinstrutor.Size = new Size(160, 22);
            lblnomeinstrutor.TabIndex = 1;
            lblnomeinstrutor.Text = "nome do Instrutor";
            // 
            // txtnomeinstrutor
            // 
            txtnomeinstrutor.Location = new Point(13, 107);
            txtnomeinstrutor.Name = "txtnomeinstrutor";
            txtnomeinstrutor.PlaceholderText = "insira o nome do instrutor";
            txtnomeinstrutor.Size = new Size(324, 23);
            txtnomeinstrutor.TabIndex = 2;
            txtnomeinstrutor.TextChanged += textBox1_TextChanged;
            // 
            // lbltelefoneinstrutor
            // 
            lbltelefoneinstrutor.AutoSize = true;
            lbltelefoneinstrutor.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltelefoneinstrutor.Location = new Point(425, 71);
            lbltelefoneinstrutor.Name = "lbltelefoneinstrutor";
            lbltelefoneinstrutor.Size = new Size(91, 26);
            lbltelefoneinstrutor.TabIndex = 3;
            lbltelefoneinstrutor.Text = "telefone";
            // 
            // txttelefoneinstrutor
            // 
            txttelefoneinstrutor.Location = new Point(387, 107);
            txttelefoneinstrutor.Name = "txttelefoneinstrutor";
            txttelefoneinstrutor.PlaceholderText = "insira o telefone do instrutor";
            txttelefoneinstrutor.Size = new Size(220, 23);
            txttelefoneinstrutor.TabIndex = 4;
            txttelefoneinstrutor.TextChanged += txttelefoneinstrutor_TextChanged;
            // 
            // lblespecialidade
            // 
            lblespecialidade.AutoSize = true;
            lblespecialidade.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblespecialidade.Location = new Point(21, 165);
            lblespecialidade.Name = "lblespecialidade";
            lblespecialidade.Size = new Size(143, 26);
            lblespecialidade.TabIndex = 5;
            lblespecialidade.Text = "especialidade";
            // 
            // txtespecialidade
            // 
            txtespecialidade.Location = new Point(12, 206);
            txtespecialidade.Name = "txtespecialidade";
            txtespecialidade.PlaceholderText = "insira a especialidade do instrutor";
            txtespecialidade.Size = new Size(342, 23);
            txtespecialidade.TabIndex = 6;
            // 
            // btncadastroinstrutor
            // 
            btncadastroinstrutor.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btncadastroinstrutor.ForeColor = Color.Blue;
            btncadastroinstrutor.Location = new Point(13, 397);
            btncadastroinstrutor.Name = "btncadastroinstrutor";
            btncadastroinstrutor.Size = new Size(210, 41);
            btncadastroinstrutor.TabIndex = 7;
            btncadastroinstrutor.Text = "cadastrar instrutor";
            btncadastroinstrutor.UseVisualStyleBackColor = true;
            btncadastroinstrutor.Click += btncadastroinstrutor_Click;
            // 
            // btnpaginainicialinstrutor
            // 
            btnpaginainicialinstrutor.Font = new Font("SansSerif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 2);
            btnpaginainicialinstrutor.ForeColor = Color.Blue;
            btnpaginainicialinstrutor.Location = new Point(441, 397);
            btnpaginainicialinstrutor.Name = "btnpaginainicialinstrutor";
            btnpaginainicialinstrutor.Size = new Size(236, 41);
            btnpaginainicialinstrutor.TabIndex = 8;
            btnpaginainicialinstrutor.Text = "pagina inicial";
            btnpaginainicialinstrutor.UseVisualStyleBackColor = true;
            btnpaginainicialinstrutor.Click += btnpaginainicialinstrutor_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnpaginainicialinstrutor);
            Controls.Add(btncadastroinstrutor);
            Controls.Add(txtespecialidade);
            Controls.Add(lblespecialidade);
            Controls.Add(txttelefoneinstrutor);
            Controls.Add(lbltelefoneinstrutor);
            Controls.Add(txtnomeinstrutor);
            Controls.Add(lblnomeinstrutor);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnomeinstrutor;
        private TextBox txtnomeinstrutor;
        private Label lbltelefoneinstrutor;
        private TextBox txttelefoneinstrutor;
        private Label lblespecialidade;
        private TextBox txtespecialidade;
        private Button btncadastroinstrutor;
        private Button btnpaginainicialinstrutor;
    }
}