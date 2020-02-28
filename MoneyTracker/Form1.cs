using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Oque vai acontecer quando clicar no LogIn
            //Se a senhar estar correta, abrirar o formulario principal

            if(TextBoxUsuario.Text == Properties.Settings.Default.AppNome && TextBoxSenha.Text == Properties.Settings.Default.AppSenha)
            {
                //LogIn
                MainForm mainform = new MainForm();
                mainform.Show(); //Mostra o outro formulario
                this.Hide(); //Fecha o formulario Antigo
            }
            else
            {
                //NEGADO!!
                MessageBox.Show("Acesso Negado !!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingUp singup = new SingUp();
            singup.Show();
            this.Hide();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
