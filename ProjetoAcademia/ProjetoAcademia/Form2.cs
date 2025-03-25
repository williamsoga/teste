using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProjetoAcademia
{
    public partial class Form2 : Form
    {
        string conexao = "Server=localhost;Database=academia;User ID=root;Password=;";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string endereco = txtendereco.Text;
            string telefone = txttelefone.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(telefone))
            {

                MessageBox.Show("Por favor, preencha todos os campos");
                return;

            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string comandoSQL = "INSERT INTO aluno (nome,endereco, telefone) VALUES (@nome, @endereco, @telefone)";

                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@endereco", endereco);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        cmd.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Aluno cadastrado com sucesso!");
                txtnome.Clear();
                txtendereco.Clear();
                txttelefone.Clear();
            }


            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar" + ex.Message);
            }
        }







        private void lblendereço_Load(object sender, EventArgs e)
        {

        }

        private void lblendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblntelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
