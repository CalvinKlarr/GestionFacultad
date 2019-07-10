using GestionFacultad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VistaGestionFacultad
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        ProgramControl db = new ProgramControl();
        verProfesControl vecont;
        agregarProfesControl agcont;
        eliminarProfeControl elcont;
        asignarProfeControl ascont;
        modificarProfeControl mocont;

        public Window3()
        {
            InitializeComponent();
            this.Closed += Window3_Closed;
        }
        //Guardar cambios al cerrar
        private void Window3_Closed(object sender, EventArgs e)
        {
            db.SaveChanges();
        }


        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox3.Children.Count == 0)
            {
                agcont = new agregarProfesControl();
                displayBox3.Children.Add(agcont);

            }
            else
            {
                displayBox3.Children.Clear();
                agcont = new agregarProfesControl();
                displayBox3.Children.Add(agcont);
            }
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox3.Children.Count == 0)
            {
                mocont = new modificarProfeControl();
                displayBox3.Children.Add(mocont);
            }
            else
            {
                displayBox3.Children.Clear();
                mocont = new modificarProfeControl();
                displayBox3.Children.Add(mocont);
            }
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox3.Children.Count == 0)
            {
                elcont = new eliminarProfeControl();
                displayBox3.Children.Add(elcont);
            }
            else
            {
                displayBox3.Children.Clear();
                elcont = new eliminarProfeControl();
                displayBox3.Children.Add(elcont);
            }
        }

        private void Asignar_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox3.Children.Count == 0)
            {
                ascont = new asignarProfeControl();
                displayBox3.Children.Add(ascont);
            }
            else
            {
                displayBox3.Children.Clear();
                ascont = new asignarProfeControl();
                displayBox3.Children.Add(ascont);
            }
        }

        private void Ver_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox3.Children.Count == 0)
            {
                vecont = new verProfesControl();
                displayBox3.Children.Add(vecont);
            }
            else
            {
                displayBox3.Children.Clear();
                vecont = new verProfesControl();
                displayBox3.Children.Add(vecont);
            }
        }
    }
}
