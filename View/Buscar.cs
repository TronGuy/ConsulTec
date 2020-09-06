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
    public partial class BuscarFRM : Form
    {
        public BuscarFRM()
        {
            InitializeComponent();
        }

        private void BuscarFRM_Load(object sender, EventArgs e)
        {
            if(TxtBuscar.Text == "")
            {

                TxtBuscar.Text = "Digite o cadastro deseja aqui...";

            }

        }


            private async void BuscarFRM_LoadAsync(object sender, EventArgs e)
            {
                //para usar depois. Caso não use apague                

                    TxtBuscar.Text = "Digite o cadastro aqui...";

                    await Task.Delay(TimeSpan.FromSeconds(value: 1));
                    TxtBuscar.Clear();
                

            }

        private void BuscarFRM_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            conexoes metodos = new conexoes();
            metodos.BtnBuscar(TxtBuscar.Text, ListBoxCadastros);
        }

        private void BuscarFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }

    }

