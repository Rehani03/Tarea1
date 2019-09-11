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
    public partial class EstructuraTiendaForm : Form
    {
        public EstructuraTiendaForm()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            EstructuraTienda.TiendaItems tienda = new EstructuraTienda.TiendaItems();
            try
            {
                int Codigo = Convert.ToInt32(CodigoNumericUpDown.Value);
                string nombre = NombreTextBox.Text;
                int cantidad = Convert.ToInt32(CantidadTextBox.Text);
                double precio = Convert.ToDouble(PrecioTextBox.Text);
                string departamento = DepartamentoTextBox.Text;
                tienda = new EstructuraTienda.TiendaItems(Codigo, nombre,
                                     cantidad, precio, departamento);
                MessageBox.Show(tienda.ToString());
            }
            catch(FormatException error)
            {
                MessageBox.Show("Errro " + error);
            }
        }
    }
}
