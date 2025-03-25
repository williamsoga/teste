namespace ProjetoAcademia
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
            btn = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btncadastroinicial = new Button();
            btnexibirinstrutores = new Button();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btn.ForeColor = Color.Blue;
            btn.Location = new Point(30, 64);
            btn.Name = "btn";
            btn.Size = new Size(180, 38);
            btn.TabIndex = 0;
            btn.Text = "cadastrar aluno";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btn2.ForeColor = Color.FromArgb(0, 0, 192);
            btn2.Location = new Point(30, 126);
            btn2.Name = "btn2";
            btn2.Size = new Size(180, 42);
            btn2.TabIndex = 1;
            btn2.Text = "alunos cadastrados";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(45, 209);
            btn3.Name = "btn3";
            btn3.Size = new Size(81, 33);
            btn3.TabIndex = 2;
            btn3.Text = "sair";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btncadastroinicial
            // 
            btncadastroinicial.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btncadastroinicial.ForeColor = Color.Blue;
            btncadastroinicial.ImageAlign = ContentAlignment.MiddleLeft;
            btncadastroinicial.Location = new Point(314, 62);
            btncadastroinicial.Name = "btncadastroinicial";
            btncadastroinicial.Size = new Size(226, 34);
            btncadastroinicial.TabIndex = 3;
            btncadastroinicial.Text = "cadastrar instrutor";
            btncadastroinicial.TextAlign = ContentAlignment.BottomCenter;
            btncadastroinicial.UseVisualStyleBackColor = true;
            btncadastroinicial.Click += btncadastroinicial_Click;
            // 
            // btnexibirinstrutores
            // 
            btnexibirinstrutores.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btnexibirinstrutores.ForeColor = Color.Blue;
            btnexibirinstrutores.Location = new Point(314, 126);
            btnexibirinstrutores.Name = "btnexibirinstrutores";
            btnexibirinstrutores.Size = new Size(217, 42);
            btnexibirinstrutores.TabIndex = 4;
            btnexibirinstrutores.Text = "instrutores cadastrados";
            btnexibirinstrutores.UseVisualStyleBackColor = true;
            btnexibirinstrutores.Click += btnexibirinstrutores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnexibirinstrutores);
            Controls.Add(btncadastroinicial);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
        private Button btn2;
        private Button btn3;
        private Button btncadastroinicial;
        private Button btnexibirinstrutores;
    }
}
