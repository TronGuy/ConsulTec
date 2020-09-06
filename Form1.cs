using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMurataConsul.View;
using ProjectMurataConsul.DAO;
using System.Diagnostics;



namespace ProjectMurataConsul
{

    public partial class Form1 : Form
    {
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        conexoes conexoes = new conexoes();
        SobreFRM sobre = new SobreFRM();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            GC.Collect();
            Environment.Exit(exitCode: 0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            conexoes.login(TxtLogin.Text, TxtSenha.Text,this);
            GC.Collect(0);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sobre.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                conexoes.TestarConexao();

            }
            catch
            {

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if(TxtSenha.PasswordChar == '*')
            {
                TxtSenha.PasswordChar = '\0';
            }
            else
            {
                TxtSenha.PasswordChar = '*';
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point Diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(Diferenca));
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {//NÃO RODE NENHUM CÓDIGO AQUI
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {//NÃO RODE NENHUM CÓDIGO AQUI 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//NÃO RODE NENHUM CÓDIGO AQUI
        }

        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {//NÃO RODE NENHUM CÓDIGO AQUI
        }

        private void TxtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                GC.Collect();
                Application.ExitThread();

            }

        
         }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
           //NÃO RODE CODIGO AQUI
        }

        private void TxtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {

                GC.Collect();
                Application.ExitThread();

            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //padrao
            //GC.Collect();
            //Dispose();
            //Application.Exit();
        }
    }
}

