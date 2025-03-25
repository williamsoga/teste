namespace ProjetoAcademia
{
    partial class Form5
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
            dataGridView2 = new DataGridView();
            btnpaginainicial = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(116, 38);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(465, 286);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // btnpaginainicial
            // 
            btnpaginainicial.Font = new Font("SansSerif", 11.2499981F, FontStyle.Bold);
            btnpaginainicial.ForeColor = Color.Blue;
            btnpaginainicial.Location = new Point(140, 387);
            btnpaginainicial.Name = "btnpaginainicial";
            btnpaginainicial.Size = new Size(399, 40);
            btnpaginainicial.TabIndex = 1;
            btnpaginainicial.Text = "pagina inicial";
            btnpaginainicial.UseVisualStyleBackColor = true;
            btnpaginainicial.Click += btnpaginainicial_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnpaginainicial);
            Controls.Add(dataGridView2);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private Button btnpaginainicial;
    }
}