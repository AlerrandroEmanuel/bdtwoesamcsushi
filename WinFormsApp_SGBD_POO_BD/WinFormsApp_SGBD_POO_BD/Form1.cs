using Npgsql;

namespace WinFormsApp_SGBD_POO_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void host_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void database_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuario_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void conexaobd_btn_Click(object sender, EventArgs e)
        {
            string host = host_box.Text;
            string port = port_box.Text;    // <-- AGORA TEMOS A PORTA
            string database = database_box.Text;
            string usuario = usuario_box.Text;
            string senha = senha_box.Text;

            
            string connString =
                $"Host={host};Port={port};Database={database};Username={usuario};Password={senha};";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open(); 
                }

                // Guarda a string global para outros forms
                ConnectionConfig.ConnectionString = connString;

                MessageBox.Show("Conectado com sucesso!");

                // Abre o Form2
                Form2 f2 = new Form2(ConnectionConfig.ConnectionString);
                f2.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }

        private void xml_btn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void json_btn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void port_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
