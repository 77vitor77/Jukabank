namespace prjAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text== String.Empty || txtSenha.Text == String.Empty)
            {

                lblMensagem.Text = "Preencha o campo";


                

            }
            if (txtUsuario.Text == "12312312312" || txtSenha.Text == "123456")
            {
                lblMensagem.Text = "Usuário valido";
            }

            if (txtUsuario.TextLength < 11 && txtSenha.TextLength < 6)
            {
                lblMensagem.Text = "Preencha corretamente os dados!";
            }

            else 
            {
                lblMensagem.Text = "Usuário inválido";
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}