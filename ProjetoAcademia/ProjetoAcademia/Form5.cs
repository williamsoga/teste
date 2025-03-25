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
    public partial class Form5 : Form
    {
        string conexao = "Server=localhost;Database=academia;User ID=root;Password=;";
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ExibirInstrutor();
        }


        private void ExibirInstrutor()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string comandoSQL = "SELECT  id_instrutor, nome,especialidade,telefone From  instrutor";

                    using (MySqlCommand cmd = new MySqlCommand(comandoSQL, conn))

                    {
                        conn.Open();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("erro ao carregar dados :" + ex.Message);


            }

        }

        private void btnpaginainicial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
