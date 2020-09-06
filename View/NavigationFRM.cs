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
using System.Timers;
using MySql.Data.MySqlClient;


namespace ProjectMurataConsul.View
{
    public partial class NavigationFRM : Form
    {
        BuscarFRM buscar_form = new BuscarFRM();
        Cadastro_Login Cadastro_Login = new Cadastro_Login();
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        conexoes metodos = new conexoes();
        public NavigationFRM()
        {
            InitializeComponent();
        }

        private void NavigationFRM_Load(object sender, EventArgs e)
        {
            metodos.TestarConexao();
        }

        private void NavigationFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void NavigationFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            //Dispose();
           // Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void ZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            var a = TxtNome.Text;
            var b = TxtEmail.Text;
            var c = TxtSenhaEmail.Text;
            var d = TxtUsuarioInternet.Text;
            var f = TxtSenhaInternet.Text;
            var g = TxtUserComputador.Text;
            var i = TxtSenhaComputador.Text;

            if (TxtNome.TextLength < 4 || TxtEmail.TextLength < 10 || TxtSenhaEmail.TextLength < 8 ||
                TxtUsuarioInternet.TextLength < 7 || TxtSenhaInternet.TextLength < 8 || TxtUserComputador.TextLength < 6
                || TxtSenhaComputador.TextLength < 8)
            {
                MessageBox.Show("O Cadastro não foi efetuado! Os dados fornecidos não possuem a quantidade mínima de caracteres exígidos.", "CADASTRO NÃO EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else {
                //STRING SUPREMA - FUNCIONA,ESSE MODELO DE STRING
                string parametros = "Server=localhost;Database=MRDB;Uid=root;Pwd= ;SslMode=none;";
                string sql = "INSERT INTO mrdb_users_cadastro VALUES("+"'"+a+"'"+","+"'"+b+"'"+","+"'"+c+"'"+","+"'"+d+"'"+","+
                    "'"+f+"'"+","+"'"+g+"'"+","+"'"+i+"')";


                MySqlConnection connection = new MySqlConnection(parametros);
                MySqlCommand comando = new MySqlCommand(sql, connection);

                
                connection.Open();

                MySqlDataReader reader = comando.ExecuteReader();
                reader.Read();

                connection.Dispose();

                MessageBox.Show(String.Format("{0}:FOI CADASTRADO!", a), "CADASTRO EFETUADO COM SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                TxtNome.Clear();
                TxtEmail.Clear();
                TxtSenhaEmail.Clear();
                TxtUsuarioInternet.Clear();
                TxtSenhaInternet.Clear();
                TxtUserComputador.Clear();
                TxtSenhaComputador.Clear();
                    
                                    
                    }


            















        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TxtNome.Enabled = false;
            TxtEmail.Enabled = false;
            TxtSenhaEmail.Enabled = false;
            TxtUsuarioInternet.Enabled = false;
            TxtSenhaInternet.Enabled = false;
            TxtSenhaComputador.Enabled = false;





        }

        private void TextBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //NÃO MUDAR O NOME (NAME) DA VARIÁVEL
            this.ActiveControl = null;

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {



        }

        private void TxtSenhaEmail_TextChanged(object sender, EventArgs e)
        {        }

        private void TxtUsuarioInternet_TextChanged(object sender, EventArgs e)
        {}

        private void TxtSenhaInternet_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenhaComputador_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastroLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Cadastro_Login.ShowDialog();

        }

        private void NavigationFRM_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;

        }

        private void NavigationFRM_MouseDown(object sender, MouseEventArgs e)
        {

            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;

        }

        private void NavigationFRM_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point Diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(Diferenca));
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.ExitThread(); }
        }

        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) {

                GC.Collect();
                Application.Exit();


            }
        }

        private void TxtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.ExitThread(); }
        }

        private void NavigationFRM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();


            }

            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            buscar_form.ShowDialog();
        }
    }
}