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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.ConfSenha = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usúario
            // 
            this.Usúario.AutoSize = true;
            this.Usúario.Location = new System.Drawing.Point(80, 240);
            this.Usúario.Name = "Usúario";
            this.Usúario.Size = new System.Drawing.Size(57, 17);
            this.Usúario.TabIndex = 0;
            this.Usúario.Text = "Usúario";
            this.Usúario.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 22);
            this.textBox2.TabIndex = 2;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(80, 297);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(49, 17);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha";
            // 
            // ConfSenha
            // 
            this.ConfSenha.AutoSize = true;
            this.ConfSenha.Location = new System.Drawing.Point(80, 357);
            this.ConfSenha.Name = "ConfSenha";
            this.ConfSenha.Size = new System.Drawing.Size(150, 17);
            this.ConfSenha.TabIndex = 4;
            this.ConfSenha.Text = "Confirmação da senha";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 377);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 437);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(350, 22);
            this.textBox4.TabIndex = 6;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(80, 417);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 17);
            this.Email.TabIndex = 7;
            this.Email.Text = "E-mail";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(199, 492);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(116, 34);
            this.Cadastrar.TabIndex = 8;
            this.Cadastrar.Text = "SingUp";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyTracker.Properties.Resources.finance_11_512;
            this.pictureBox1.Location = new System.Drawing.Point(158, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(512, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ConfSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Usúario);
            this.Name = "SingUp";
            this.Text = "SingUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usúario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label ConfSenha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}