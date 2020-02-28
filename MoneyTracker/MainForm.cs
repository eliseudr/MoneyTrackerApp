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
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.TransaçõesTable'. Você pode movê-la ou removê-la conforme necessário.
            this.transaçõesTableTableAdapter.Fill(this.dataSet1.TransaçõesTable);

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

            //Ira adicionar a transaçao direto no GridView
            this.transaçõesTableTableAdapter.Fill(this.dataSet1.TransaçõesTable);
        }

        private void Voltar2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            transaçõesTableTableAdapter.Update(dataSet1);
            dataGridView1.EndEdit();

            this.transaçõesTableTableAdapter.Fill(this.dataSet1.TransaçõesTable);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
  
        }
    }
}
