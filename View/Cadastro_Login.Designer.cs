namespace ProjectMurataConsul.View
{
    partial class Cadastro_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCadastroLogin = new System.Windows.Forms.TextBox();
            this.TxtCadastroSenha = new System.Windows.Forms.TextBox();
            this.BtnCadastroLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            // 
            // TxtCadastroLogin
            // 
            this.TxtCadastroLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCadastroLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadastroLogin.Location = new System.Drawing.Point(104, 46);
            this.TxtCadastroLogin.MaxLength = 15;
            this.TxtCadastroLogin.Name = "TxtCadastroLogin";
            this.TxtCadastroLogin.Size = new System.Drawing.Size(180, 25);
            this.TxtCadastroLogin.TabIndex = 1;
            this.TxtCadastroLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCadastroLogin_KeyUp);
            // 
            // TxtCadastroSenha
            // 
            this.TxtCadastroSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadastroSenha.Location = new System.Drawing.Point(104, 91);
            this.TxtCadastroSenha.MaxLength = 15;
            this.TxtCadastroSenha.Name = "TxtCadastroSenha";
            this.TxtCadastroSenha.PasswordChar = '*';
            this.TxtCadastroSenha.Size = new System.Drawing.Size(180, 25);
            this.TxtCadastroSenha.TabIndex = 2;
            this.TxtCadastroSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCadastroSenha_KeyUp);
            // 
            // BtnCadastroLogin
            // 
            this.BtnCadastroLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroLogin.Location = new System.Drawing.Point(104, 180);
            this.BtnCadastroLogin.Name = "BtnCadastroLogin";
            this.BtnCadastroLogin.Size = new System.Drawing.Size(101, 30);
            this.BtnCadastroLogin.TabIndex = 3;
            this.BtnCadastroLogin.Text = "Cadastrar";
            this.BtnCadastroLogin.UseVisualStyleBackColor = true;
            this.BtnCadastroLogin.Click += new System.EventHandler(this.BtnCadastroLogin_Click);
            this.BtnCadastroLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnCadastroLogin_KeyUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(241, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 22);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Visualizar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(284, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Mínimo de 8 caracteres";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBox1_KeyUp);
            // 
            // Cadastro_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 247);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnCadastroLogin);
            this.Controls.Add(this.TxtCadastroSenha);
            this.Controls.Add(this.TxtCadastroLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE LOGIN - acessos ao sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cadastro_Login_FormClosed);
            this.Load += new System.EventHandler(this.Cadastro_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCadastroLogin;
        private System.Windows.Forms.TextBox TxtCadastroSenha;
        private System.Windows.Forms.Button BtnCadastroLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}