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
    public partial class DiseñoInventarioForm : Form
    {
        public DiseñoInventarioForm()
        {
            InitializeComponent();
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatosButton_Click(object sender, EventArgs e)
        {
            DiseñoDeClaseInventario.InventarioTienda tienda = new DiseñoDeClaseInventario.InventarioTienda();
            try
            {
                int ID = Convert.ToInt32(IDProductoNumericUpDown1.Value);
                string departamento = Convert.ToString(DepartamentoComboBox.SelectedItem);
                string nombreProducto = NombreTextBox.Text;
                double costroProducto = Convert.ToDouble(CostoTextBox.Text);
                double PrecioProducto = Convert.ToDouble(PrecioTextBox.Text);
                int cantidadProducto = Convert.ToInt32(CantidadmaskedTextBox.Text);
                string descripcionProducto = DescripcionTextBox.Text;
                double ITBIS = Convert.ToDouble(ITBISTextBox.Text);
                tienda = new DiseñoDeClaseInventario.InventarioTienda(ID, nombreProducto, departamento, costroProducto
                            , PrecioProducto, cantidadProducto, descripcionProducto, ITBIS);
                MessageBox.Show(tienda.ToString());
            }
            catch (Exception error)
            {

                MessageBox.Show("Error" + error);
            }
        }
    }
}
