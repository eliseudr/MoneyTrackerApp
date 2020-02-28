namespace MoneyTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Montante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataTransacao = new System.Windows.Forms.DateTimePicker();
            this.Pagamento = new System.Windows.Forms.RadioButton();
            this.Recebimento = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdicionarTransacao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Voltar2 = new System.Windows.Forms.Button();
            this.dataSet1 = new MoneyTracker.DataSet1();
            this.transaçõesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaçõesTableTableAdapter = new MoneyTracker.DataSet1TableAdapters.TransaçõesTableTableAdapter();
            this.transaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTipoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.counterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaçõesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Montante
            // 
            this.Montante.Location = new System.Drawing.Point(34, 79);
            this.Montante.Margin = new System.Windows.Forms.Padding(2);
            this.Montante.Name = "Montante";
            this.Montante.Size = new System.Drawing.Size(801, 20);
            this.Montante.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Montante da transfêrencia";
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(34, 123);
            this.Descricao.Margin = new System.Windows.Forms.Padding(2);
            this.Descricao.Multiline = true;
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(801, 68);
            this.Descricao.TabIndex = 2;
            this.Descricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // DataTransacao
            // 
            this.DataTransacao.Location = new System.Drawing.Point(35, 208);
            this.DataTransacao.Margin = new System.Windows.Forms.Padding(2);
            this.DataTransacao.Name = "DataTransacao";
            this.DataTransacao.Size = new System.Drawing.Size(151, 20);
            this.DataTransacao.TabIndex = 5;
            // 
            // Pagamento
            // 
            this.Pagamento.AutoSize = true;
            this.Pagamento.Checked = true;
            this.Pagamento.Location = new System.Drawing.Point(34, 242);
            this.Pagamento.Margin = new System.Windows.Forms.Padding(2);
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.Size = new System.Drawing.Size(79, 17);
            this.Pagamento.TabIndex = 6;
            this.Pagamento.TabStop = true;
            this.Pagamento.Text = "Pagamento";
            this.Pagamento.UseVisualStyleBackColor = true;
            // 
            // Recebimento
            // 
            this.Recebimento.AutoSize = true;
            this.Recebimento.Location = new System.Drawing.Point(129, 242);
            this.Recebimento.Margin = new System.Windows.Forms.Padding(2);
            this.Recebimento.Name = "Recebimento";
            this.Recebimento.Size = new System.Drawing.Size(88, 17);
            this.Recebimento.TabIndex = 7;
            this.Recebimento.TabStop = true;
            this.Recebimento.Text = "Recebimento";
            this.Recebimento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transaçãoDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.transDataDataGridViewTextBoxColumn,
            this.transTipoDataGridViewCheckBoxColumn,
            this.counterIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaçõesTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 293);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 329);
            this.dataGridView1.TabIndex = 8;
            // 
            // AdicionarTransacao
            // 
            this.AdicionarTransacao.Location = new System.Drawing.Point(704, 221);
            this.AdicionarTransacao.Margin = new System.Windows.Forms.Padding(2);
            this.AdicionarTransacao.Name = "AdicionarTransacao";
            this.AdicionarTransacao.Size = new System.Drawing.Size(131, 28);
            this.AdicionarTransacao.TabIndex = 9;
            this.AdicionarTransacao.Text = "Adicionar Transação";
            this.AdicionarTransacao.UseVisualStyleBackColor = true;
            this.AdicionarTransacao.Click += new System.EventHandler(this.AdicionarTransacao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minhas Transações";
            // 
            // Voltar2
            // 
            this.Voltar2.Location = new System.Drawing.Point(760, 22);
            this.Voltar2.Name = "Voltar2";
            this.Voltar2.Size = new System.Drawing.Size(75, 28);
            this.Voltar2.TabIndex = 11;
            this.Voltar2.Text = "Voltar";
            this.Voltar2.UseVisualStyleBackColor = true;
            this.Voltar2.Click += new System.EventHandler(this.Voltar2_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaçõesTableBindingSource
            // 
            this.transaçõesTableBindingSource.DataMember = "TransaçõesTable";
            this.transaçõesTableBindingSource.DataSource = this.dataSet1;
            // 
            // transaçõesTableTableAdapter
            // 
            this.transaçõesTableTableAdapter.ClearBeforeFill = true;
            // 
            // transaçãoDataGridViewTextBoxColumn
            // 
            this.transaçãoDataGridViewTextBoxColumn.DataPropertyName = "Transação";
            this.transaçãoDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.transaçãoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transaçãoDataGridViewTextBoxColumn.Name = "transaçãoDataGridViewTextBoxColumn";
            this.transaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.transaçãoDataGridViewTextBoxColumn.Width = 115;
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            this.descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriçãoDataGridViewTextBoxColumn.Width = 115;
            // 
            // transDataDataGridViewTextBoxColumn
            // 
            this.transDataDataGridViewTextBoxColumn.DataPropertyName = "TransData";
            this.transDataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.transDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transDataDataGridViewTextBoxColumn.Name = "transDataDataGridViewTextBoxColumn";
            this.transDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.transDataDataGridViewTextBoxColumn.Width = 115;
            // 
            // transTipoDataGridViewCheckBoxColumn
            // 
            this.transTipoDataGridViewCheckBoxColumn.DataPropertyName = "TransTipo";
            this.transTipoDataGridViewCheckBoxColumn.HeaderText = "Tipo";
            this.transTipoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.transTipoDataGridViewCheckBoxColumn.Name = "transTipoDataGridViewCheckBoxColumn";
            this.transTipoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.transTipoDataGridViewCheckBoxColumn.Width = 115;
            // 
            // counterIDDataGridViewTextBoxColumn
            // 
            this.counterIDDataGridViewTextBoxColumn.DataPropertyName = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.HeaderText = "Contador";
            this.counterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.counterIDDataGridViewTextBoxColumn.Name = "counterIDDataGridViewTextBoxColumn";
            this.counterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.counterIDDataGridViewTextBoxColumn.Width = 115;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(704, 264);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(131, 28);
            this.ButtonUpdate.TabIndex = 12;
            this.ButtonUpdate.Text = "Atualizar";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(891, 648);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.Voltar2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdicionarTransacao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Recebimento);
            this.Controls.Add(this.Pagamento);
            this.Controls.Add(this.DataTransacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Montante);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MinhasTransações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaçõesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Montante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataTransacao;
        private System.Windows.Forms.RadioButton Pagamento;
        private System.Windows.Forms.RadioButton Recebimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdicionarTransacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Voltar2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource transaçõesTableBindingSource;
        private DataSet1TableAdapters.TransaçõesTableTableAdapter transaçõesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transTipoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}