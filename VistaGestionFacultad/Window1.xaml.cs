using GestionFacultad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        //Contexto de la base de datos
        ProgramControl db;
        alumnoControl alcont;
        viewAlumnoControl valcont;
        inscribirControl incont;
        asignaturasControl ascont;
        cursosControl cucont;
        //Constructor, se instancia el contexto de la DB, y se agrega un evento al cerrarse la ventana
        public Window1(ProgramControl programControl)
        {
            db = programControl;
            InitializeComponent();
            DataContext = this;
            this.Closed += Window1_Closed;
        }
        //Guarda los cambios en la db
        private void Window1_Closed(object sender, EventArgs e)
        {
            db.SaveChanges();
            
        }

        private void Inscribir_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Children.Count == 0)
            {
                alcont = new alumnoControl();
                displayBox.Children.Add(alcont);
            }
            else
            {
                displayBox.Children.Clear();
                alcont = new alumnoControl();
                displayBox.Children.Add(alcont);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(displayBox.Children.Count == 0)
            {
                valcont = new viewAlumnoControl();
                displayBox.Children.Add(valcont);
            }
            else
            {
                displayBox.Children.Clear();
                valcont = new viewAlumnoControl();
                displayBox.Children.Add(valcont);
            }
            

        }

        private void Inscribir_Click_1(object sender, RoutedEventArgs e)
        {
            if(displayBox.Children.Count == 0)
            {
                incont = new inscribirControl();
                displayBox.Children.Add(incont);
            }
            else
            {
                displayBox.Children.Clear();
                incont = new inscribirControl();
                displayBox.Children.Add(incont);
            }
        }

        

        private void VerAsig_Click(object sender, RoutedEventArgs e)
        {
            if(displayBox.Children.Count == 0)
            {
                ascont = new asignaturasControl();
                displayBox.Children.Add(ascont);
            }
            else
            {
                displayBox.Children.Clear();
                ascont = new asignaturasControl();
                displayBox.Children.Add(ascont);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void VerCurso_Click(object sender, RoutedEventArgs e)
        {
            if (displayBox.Children.Count == 0)
            {
                cucont = new cursosControl();
                displayBox.Children.Add(cucont);
            }
            else
            {
                displayBox.Children.Clear();
                cucont = new cursosControl();
                displayBox.Children.Add(cucont);
            }
        }
    }
}
