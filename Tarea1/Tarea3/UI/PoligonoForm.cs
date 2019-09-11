using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tareas.Tarea3;

namespace Tarea1.Tarea3
{
    public partial class PoligonoForm : Form
    {
        public PoligonoForm()
        {
            InitializeComponent();
        }

        private void CalcularPerimetroButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numLados = Convert.ToInt32(NumeroLadosMaskedText.Text);
                double longLados = Convert.ToDouble(LongitudTextBox.Text);
                Poligono poligono = new Poligono(numLados, longLados);

                MessageBox.Show(poligono.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
              
            }
        }
    }
}
