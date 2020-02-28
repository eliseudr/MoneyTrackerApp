namespace MoneyTracker
{
    partial class SingUp
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
            this.Usúario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.ConfSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmaçaoSenha = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usúario
            // 
            this.Usúario.AutoSize = true;
            this.Usúario.Location = new System.Drawing.Point(60, 195);
            this.Usúario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usúario.Name = "Usúario";
            this.Usúario.Size = new System.Drawing.Size(43, 13);
            this.Usúario.TabIndex = 0;
            this.Usúario.Text = "Usúario";
            this.Usúario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(62, 211);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(264, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(62, 258);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(264, 20);
            this.textBoxSenha.TabIndex = 2;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(60, 241);
            this.Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha";
            // 
            // ConfSenha
            // 
            this.ConfSenha.AutoSize = true;
            this.ConfSenha.Location = new System.Drawing.Point(60, 290);
            this.ConfSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfSenha.Name = "ConfSenha";
            this.ConfSenha.Size = new System.Drawing.Size(113, 13);
            this.ConfSenha.TabIndex = 4;
            this.ConfSenha.Text = "Confirmação da senha";
            // 
            // textBoxConfirmaçaoSenha
            // 
            this.textBoxConfirmaçaoSenha.Location = new System.Drawing.Point(62, 306);
            this.textBoxConfirmaçaoSenha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConfirmaçaoSenha.Name = "textBoxConfirmaçaoSenha";
            this.textBoxConfirmaçaoSenha.PasswordChar = '*';
            this.textBoxConfirmaçaoSenha.Size = new System.Drawing.Size(264, 20);
            this.textBoxConfirmaçaoSenha.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(62, 355);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(264, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(60, 339);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "E-mail";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(219, 395);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(87, 28);
            this.Cadastrar.TabIndex = 8;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyTracker.Properties.Resources.finance_11_512;
            this.pictureBox1.Location = new System.Drawing.Point(118, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonVoltar
            // 
            this.ButtonVoltar.Location = new System.Drawing.Point(102, 395);
            this.ButtonVoltar.Name = "ButtonVoltar";
            this.ButtonVoltar.Size = new System.Drawing.Size(87, 28);
            this.ButtonVoltar.TabIndex = 10;
            this.ButtonVoltar.Text = "Voltar";
            this.ButtonVoltar.UseVisualStyleBackColor = true;
            this.ButtonVoltar.Click += new System.EventHandler(this.ButtonVoltar_Click);
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 456);
            this.Controls.Add(this.ButtonVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxConfirmaçaoSenha);
            this.Controls.Add(this.ConfSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.Usúario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SingUp";
            this.Text = "SingUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SingUp_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usúario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label ConfSenha;
        private System.Windows.Forms.TextBox textBoxConfirmaçaoSenha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonVoltar;
    }
}