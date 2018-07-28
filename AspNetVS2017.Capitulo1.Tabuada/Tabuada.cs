using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo1.Tabuada
{
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 0 && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                {
                    if (e.KeyChar == 13)
                    {
                        Calcular();
                    }
                }
            }

            else
            {
                e.Handled = true;
            }

        }

        private void Calcular()
        {
            tabuadalistBox.Items.Clear();

            var tabuada = Convert.ToInt32(txtNumero.Text);

            for (int i = 0; i <= 10; i++)
            {
                tabuadalistBox.Items.Add($"{tabuada} x {i} = {tabuada*i}");
            }

            txtNumero.Focus();
            txtNumero.SelectAll();
        }
    }
}
