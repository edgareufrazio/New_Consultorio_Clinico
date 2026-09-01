using Microsoft.Data.SqlClient;

namespace tarefa_sala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conexao_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            conn.Conectar();

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Connection conn = new Connection();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Connection conn = new Connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}

