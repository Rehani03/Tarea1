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
    public partial class EnumNeumaticosForm : Form
    {
        public EnumNeumaticosForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            string complemeto = "Mi neumático ahora es: ";
            Enumeracion neumatico = new Enumeracion();
            MessageBox.Show(complemeto + 
                neumatico.AsignarValoresEImprimir(NeumaticoComboBox.SelectedIndex).ToString() +" de " + CriterioTextBox.Text);
        }
    }
}
