namespace ProjetoAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexibirinstrutores_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();
        }

        private void btncadastroinicial_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();
        }
    }
}
