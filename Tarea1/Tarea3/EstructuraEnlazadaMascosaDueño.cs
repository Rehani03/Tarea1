using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Tarea3
{
    //Ejercicio 3 del capitulo 9
    public class EstructuraEnlazadaMascosaDueño
    {
        public struct Mascota
        {
            public string NombreMascota;
            public string ColorMascota;
            public string RazaMascota;
            public double PesoMascota;

            
            public Mascota(string nombreMascota, string colorMascota, string razaMascota, double pesoMascota)
            {
                NombreMascota = nombreMascota;
                ColorMascota = colorMascota;
                RazaMascota = razaMascota;
                PesoMascota = pesoMascota;
            }
        }

        public struct Dueño
        {
            public string NombreDueño;
            public string ApellidoDueño;
            public int EdadDueño;
            public Mascota Conejo;

            public Dueño(string nombreDueño, string apellidoDueño, int edadDueño, string nombreMascota, 
                            string colorMascota, string razaMascota, double pesoMascota)
            {
                NombreDueño = nombreDueño;
                ApellidoDueño = apellidoDueño;
                EdadDueño = edadDueño;
                Conejo = new Mascota(nombreMascota,colorMascota, razaMascota, pesoMascota);
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Nombre Dueño:" + NombreDueño + "\nApellido Dueño:" + ApellidoDueño 
                    + "\nEdad Dueño:" + EdadDueño+ "\nNombre Mascoa:" + Conejo.NombreMascota + "\nColor Mascoa:" 
                    + Conejo.ColorMascota + "\nRaza Mascota:" +Conejo.RazaMascota +"\nPeso Mascota:"+Conejo.PesoMascota);
                return (sb.ToString());
            }

        }

    }
}
