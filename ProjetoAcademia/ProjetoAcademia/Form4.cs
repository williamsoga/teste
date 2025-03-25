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
    public partial class Form4 : Form
    {
        string conexao = "Server=localhost;Database=academia;User ID=root;Password=;";
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncadastroinstrutor_Click(object sender, EventArgs e)
        {
            string nomeinstrutor = txtnomeinstrutor.Text;
            string especialidade = txtespecialidade.Text;
            string telefoneinstrutor = txttelefoneinstrutor.Text;

            if (string.IsNullOrEmpty(nomeinstrutor) || string.IsNullOrEmpty(especialidade) || string.IsNullOrEmpty(telefoneinstrutor))
            {

                MessageBox.Show("Por favor, preencha todos os campos");
                return;

            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string comandoSQL = "INSERT INTO instrutor (nome,especialidade, telefone) VALUES (@nome, @especialidade, @telefone)";

                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeinstrutor);
                        cmd.Parameters.AddWithValue("@especialidade", especialidade);
                        cmd.Parameters.AddWithValue("@telefone", telefoneinstrutor);

                        cmd.ExecuteNonQuery();
                    }

                }
                MessageBox.Show(" instrutor cadastrado com sucesso!");
                txtnomeinstrutor.Clear();
                txtespecialidade.Clear();
                txttelefoneinstrutor.Clear();
            }


            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar" + ex.Message);
            }
        }

        private void btnpaginainicialinstrutor_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void txttelefoneinstrutor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

