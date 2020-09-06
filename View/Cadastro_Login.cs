using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMurataConsul.DAO;


namespace ProjectMurataConsul.View
{
    public partial class Cadastro_Login : Form
    {
        conexoes metodos = new conexoes();
        public Cadastro_Login()
        {
            InitializeComponent();
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (TxtCadastroSenha.PasswordChar == '*')
            {
                TxtCadastroSenha.PasswordChar = '\0';
            }
            else
            {
                TxtCadastroSenha.PasswordChar = '*';
            }
        }

        private void BtnCadastroLogin_Click(object sender, EventArgs e)

        {
            this.ActiveControl = null;
            if (TxtCadastroLogin.TextLength < 4 || TxtCadastroSenha.TextLength <8)
            {
                MessageBox.Show("O Cadastro não foi efetuado! Os dados fornecidos não possuem a quantidade mínima de caracteres exígidos.", "O NÚMERO MÍNIMO DE CARACTERES NÃO FOI CORRESPONDIDO", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else
            {
                string valorComboBox = comboBox1.GetItemText(comboBox1.SelectedItem);
                metodos.CadastroAcessosLogin(TxtCadastroLogin.Text, TxtCadastroSenha.Text,valorComboBox);
                

                TxtCadastroLogin.Clear();
                TxtCadastroSenha.Clear();
                




            }
        }

        private void TxtCadastroLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
                comboBox1.Items.Clear();

            }
        }

        private void TxtCadastroSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                comboBox1.Items.Clear();

            }
        }

        private void BtnCadastroLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();
                comboBox1.Items.Clear();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       
        private void Cadastro_Login_Load(object sender, EventArgs e)
        {

            
            comboBox1.Items.Add("Administrador");
            comboBox1.Items.Add("Usuário");
            comboBox1.SelectedIndex = 1;
        }

        private void Cadastro_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
                comboBox1.Items.Clear();

        }

        private void ComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.ActiveControl = null;
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Cadastro_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
         
            GC.Collect();
            

        }
    }
}
