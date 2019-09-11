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
    public partial class EstructuraDueñoMascotaForm : Form
    {
        public EstructuraDueñoMascotaForm()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Tareas.Tarea3.EstructuraEnlazadaMascosaDueño.Dueño dueño = new Tareas.Tarea3.EstructuraEnlazadaMascosaDueño.Dueño();
            try
            {
                string nombreDueño = NombreTextBox.Text;
                string apellidoDueño = ApellidoTextBox.Text;
                int edadDueño = Convert.ToInt32(EdadTextBox.Text);
                string nombreMascota = NombreMascotaTextBox.Text;
                string colorMascota = ColorMascotaTextBox.Text;
                string razaMascota = RazaMascotaTextBox.Text;
                double pesoMascota = Convert.ToDouble(PesoTextBox.Text);
                dueño = new Tareas.Tarea3.EstructuraEnlazadaMascosaDueño.Dueño(nombreDueño, apellidoDueño,
                                edadDueño, nombreMascota, colorMascota, razaMascota, pesoMascota);
                MessageBox.Show(dueño.ToString());
            }
            catch (Exception error)
            {

                MessageBox.Show("Error " + error);
            }
        }
    }
}
