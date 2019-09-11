using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea1.Tarea3.UI;
using Tareas.Tarea3;

namespace Tarea1.Tarea3
{
    public partial class MenuTarea3Form : Form
    {
        public MenuTarea3Form()
        {
            InitializeComponent();
        }

        private void EstructuraQueGuardaLosProductosDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraTiendaForm tienda = new EstructuraTiendaForm();
            tienda.Show();
        }

        private void EstructuraEnlazadaQueGuardaInformaciónDelDueñoYSuMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstructuraDueñoMascotaForm mascot = new EstructuraDueñoMascotaForm();
            mascot.Show();
        }

        private void EnumeraciónParaDiferentesNeumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnumNeumaticosForm enf = new EnumNeumaticosForm();
            enf.Show();

        }

        private void ExcepcionesQuePuedenOcurrirEnArreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excepciones exp = new Excepciones();
            exp.ExcepcionesArreglos();
        }

        private void ExcepcionesQuePuedenOcurrirEnStreamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excepciones exp = new Excepciones();
            exp.ExcepcionesStream();
        }

        private void ExcepcionesQuePuedenOcurrirConElMétodoWriteLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excepciones exp = new Excepciones();
            exp.ExcepcionesWriteLine();
        }

        private void ClasePoligonoConSobrecargaPropiedadesYMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoligonoForm p = new PoligonoForm();
            p.Show();
        }

        private void DiseñoDeUnaClaseParaLlevarElInventarioDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiseñoInventarioForm dif = new DiseñoInventarioForm();
            dif.Show();
        }

        private void CrearUnaClaseParaLlevarLaInformaciónDeLosEstudiantesDeUnaEscuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscuelaRegistroForm erf = new EscuelaRegistroForm();
            erf.Show();
        }
    }
}
