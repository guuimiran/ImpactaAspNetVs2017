using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Fretes
{
    public partial class Frete : Form
    {
        public Frete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtFrete.Clear();
            txtResultado.Clear();
            txtValor.Clear();
            cb_UF.SelectedIndex = -1;
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var erros = ValidaFormulario();

            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                "VALIDAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
  
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(txtValor.Text);
            var nordeste = new List<string> {"BA", "PE","AL"};

            switch (cb_UF.Text.ToUpper())
            {
                case "SP":
                    percentual = 0.2m;
                    break;

                case "RJ":
                    percentual = 0.3m;
                    break;

                case "MG":
                    percentual = 0.35m;
                    break;

                case var uf when nordeste.Contains(uf):
                    percentual = 0.5m;
                    break;

                case "AM":
                    percentual = 0.6m;
                    break;

                case null:
                    throw new NullReferenceException("A UF  nao pode ser Nula");

                default:
                    percentual = 0.75m;
                    break;
            }

            txtFrete.Text = percentual.ToString("P2");
            txtResultado.Text = (valor * (1 + percentual)).ToString("c");
        }

        private List<string> ValidaFormulario()
        {
            var erros = new List<string>();

           if(txtCliente.Text.Trim() == string.Empty)
            {
                erros.Add("O campo Cliente é obrigatório.");
            }

            if (string.IsNullOrEmpty(txtValor.Text.Trim()))
            {
                erros.Add("O campo Valor é obrigatório.");
            }
            else
            {
                if (!decimal.TryParse(txtValor.Text.Trim(), out decimal valor))
                {
                    erros.Add("O campo valor está com formato incorreto.");
                }
            }

            if(cb_UF.SelectedIndex == -1)
            {
                erros.Add("Selecione o campo UF.");
            }

            return erros;
        }


    }
}
