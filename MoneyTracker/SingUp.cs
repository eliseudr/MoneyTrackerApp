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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            String novoUsario = textBoxUsuario.Text;
            String novaSenha = textBoxSenha.Text;
            String ConfirmSenha = textBoxConfirmaçaoSenha.Text;
            String novoEmail = textBoxEmail.Text;

            if(novaSenha != ConfirmSenha)
            {
                MessageBox.Show("Senhas divergentes !!");
            }
            else
            {
                MessageBox.Show("Cadastro efetuado !!");
                DataSet1TableAdapters.CadastroUsuarioTableAdapter Adapter = new DataSet1TableAdapters.CadastroUsuarioTableAdapter();
                Adapter.InsertCadastroUsuario(novoUsario, novaSenha, novoEmail);

            }

        }

        private void ButtonVoltar_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
