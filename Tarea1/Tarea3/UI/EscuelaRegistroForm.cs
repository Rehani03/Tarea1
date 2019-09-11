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

namespace Tarea1.Tarea3.UI
{
    public partial class EscuelaRegistroForm : Form
    {
        public EscuelaRegistroForm()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string matricula = MatriculaTextBox.Text;
                string nombres = NombresTextBox.Text;
                string apellidos = ApellidosTexBox.Text;
                int edad = Convert.ToInt32(EdadmaskedTextBox1.Text);
                string direccion = DireccionTextBox1.Text;
                string grado = GradoTextBox.Text;
                string seccion = SeccionTextBox.Text;
                double promedio = Convert.ToDouble(PromedioTextBox.Text);
                string nombrePadre = NombrePadreTextBox.Text;
                string cedulaPadre = CedulaPadremaskedTextBox.Text;
                string nombreMadre = NombreMadreTextBox.Text;
                string cedulaMadre = CedulaMadremaskedTextBox.Text;
                EstudianteEscuela estudiante = new EstudianteEscuela(matricula,nombres,
                    apellidos,edad, direccion, grado, seccion, promedio, nombrePadre,
                    cedulaPadre, nombreMadre, cedulaMadre);
                MessageBox.Show(estudiante.ToString());
                
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
        }
    }
}
