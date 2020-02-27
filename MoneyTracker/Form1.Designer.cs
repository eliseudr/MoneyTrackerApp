namespace MoneyTracker
{
    partial class LogIn
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.SingUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Location = new System.Drawing.Point(66, 280);
            this.TextBoxSenha.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '*';
            this.TextBoxSenha.Size = new System.Drawing.Size(255, 20);
            this.TextBoxSenha.TabIndex = 1;
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(142, 335);
            this.Log.Margin = new System.Windows.Forms.Padding(2);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(87, 27);
            this.Log.TabIndex = 2;
            this.Log.Text = "Entrar";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usúario";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Location = new System.Drawing.Point(66, 228);
            this.TextBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(255, 20);
            this.TextBoxUsuario.TabIndex = 4;
            // 
            // SingUp
            // 
            this.SingUp.Location = new System.Drawing.Point(142, 375);
            this.SingUp.Margin = new System.Windows.Forms.Padding(2);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(87, 28);
            this.SingUp.TabIndex = 5;
            this.SingUp.Text = "Cadastrar";
            this.SingUp.UseVisualStyleBackColor = true;
            this.SingUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyTracker.Properties.Resources.finance_11_512;
            this.pictureBox1.Location = new System.Drawing.Point(121, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SingUp);
            this.Controls.Add(this.TextBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "MoneyTracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Button SingUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

