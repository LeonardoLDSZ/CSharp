using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparativoCombustível
{
    public partial class GasolinaAlcool : Form
    {
        public GasolinaAlcool()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                            
            double valorAlcool = Convert.ToDouble(txtAlcool.Text);
            double valorGasolina = Convert.ToDouble(txtGasolina.Text);
            double resultado = valorAlcool / valorGasolina;
            txtResultado.Text = resultado.ToString();

            if (resultado <= 0.7)
            {
                MessageBox.Show("Mais econômico abastecer com álcool/etanol.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Mais economico abastecer com gasolina.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void GasolinaAlcool_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
