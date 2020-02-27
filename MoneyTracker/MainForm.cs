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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarTransacao_Click(object sender, EventArgs e)
        {
            //Codigos para adiconar dados no database
            //Funçao Convert.ToDecimal para converter o texto inserido em decimal
            decimal TransValor = Convert.ToDecimal(Montante.Text);

            //Ira inserir a descrição 
            string TransDescricao = Descricao.Text;

            DateTime TransData = DataTransacao.Value;

            //Pagamento ou recebimento foram definidos como ''bit'' 1 ou 0.
            int TransTipo = 0;


            if( Pagamento.Checked)
            {
                TransTipo = 0;
            }
            if ( Recebimento.Checked)
            {
                TransTipo = 1;
            }

            int CounterID = 1;

            DataSet1TableAdapters.TransaçõesTableTableAdapter MyAdapter = new DataSet1TableAdapters.TransaçõesTableTableAdapter();
            MyAdapter.InsertTransacao(TransValor, TransDescricao, TransData, Convert.ToBoolean(TransTipo), CounterID);

            MessageBox.Show("Concluido !!");

        }

        private void Voltar2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
