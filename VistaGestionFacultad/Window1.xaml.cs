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

        public void sendText(string text)
        {

        }
        //Evento al hacer click en ver alumnos por curso
        private void AlumnosPorcurso_Click(object sender, RoutedEventArgs e)
        {
            legajoAlumno.Visibility = Visibility.Collapsed;
            elegirCursoTexto.Visibility = Visibility.Visible;
            elegirAsig.Visibility = Visibility.Visible;
            elegirCursoTexto.Text = "Elija el curso del que desea ver los alumnos";
            var dset = db.Cursos;
            DbSet<Curso> qry = dset;
            qry.Load();

            cursoBox.ItemsSource = dset.Local.ToBindingList();
            alumnosGrid.Visibility = Visibility.Collapsed;
            confirmButton.Visibility = Visibility.Collapsed;
            elegirAsig.Visibility = Visibility.Collapsed;
            cursoBox.Visibility = Visibility.Visible;
            confirmButton.Content = "Confirmar";


        }
        //Evento del combobox de elegir asignatura, no cambie el nombre y quedo asi
        private void ElegirCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Asignaturas asig =(Asignaturas)elegirAsig.SelectedItem;
            db.Asigns.Load();
            var dset = db.Asigns;
            DbSet<Asignaturas> qry = dset;
            qry.Load();
            foreach (var item in dset)
            {
                if (item.Asign.Equals(asig.Asign))
                {
                    asig = item;
                }
            }

            alumnosGrid.Visibility = Visibility.Visible;
            alumnosGrid.ItemsSource = asig.inscriptos;

            confirmButton.Visibility = Visibility.Visible;

            
            
        }
        //Evento al hacer click en ver alumnos por materia
        private void AlumnosPorMateria_Click(object sender, RoutedEventArgs e)
        {
            legajoAlumno.Visibility = Visibility.Collapsed;
            elegirCursoTexto.Visibility = Visibility.Visible;
            elegirAsig.Visibility = Visibility.Visible;
            elegirCursoTexto.Text = "Elija la materia de la que desea ver los alumnos";
            var dset = db.Asigns;
            DbSet<Asignaturas> qry = dset;
            qry.Load();

            elegirAsig.ItemsSource = dset.Local.ToBindingList();
            alumnosGrid.Visibility = Visibility.Collapsed;
            confirmButton.Visibility = Visibility.Collapsed;
            cursoBox.Visibility = Visibility.Collapsed;
            confirmButton.Content = "Confirmar";
            


        }
        //Evento al hacer click en ver calificaciones
        private void VerCalificaciones_Click(object sender, RoutedEventArgs e)
        {
            elegirCursoTexto.Visibility = Visibility.Collapsed;
            elegirCursoTexto.Visibility = Visibility.Collapsed;
            legajoAlumno.Visibility = Visibility.Collapsed;
            confirmButton.Visibility = Visibility.Visible;
            confirmButton.Content = "Aceptar";
            elegirAsig.Visibility = Visibility.Collapsed;
            alumnosGrid.Visibility = Visibility.Visible;
            var dset = db.Califications;
            DbSet<Calificacion> qry = dset;
            qry.Load();
            alumnosGrid.ItemsSource = dset.Local.ToBindingList();
            cursoBox.Visibility = Visibility.Collapsed;

        }
        //Unused
        private void SubirCalificaciones_Click(object sender, RoutedEventArgs e)
        {
            
        }
        //Unused
        private void BajaAlumno_Click(object sender, RoutedEventArgs e)
        {
            

        }
        //Evento al hacer click en modificar alumnos
        private void ModificarAlumno_Click(object sender, RoutedEventArgs e)
        {
            
            elegirCursoTexto.Visibility = Visibility.Collapsed;
            legajoAlumno.Visibility = Visibility.Collapsed;
            confirmButton.Visibility = Visibility.Visible;
            cursoBox.Visibility = Visibility.Collapsed;
            confirmButton.Content = "Confirmar";
            
            elegirAsig.Visibility = Visibility.Collapsed;
            alumnosGrid.Visibility = Visibility.Visible;
            var dset = db.Alumnos;
            DbSet<Alumno> qry = dset;
            qry.Load();
            alumnosGrid.ItemsSource = dset.Local.ToBindingList();
            
            
           
        }
        //Unused
        private void AlumnosGrid_TargetUpdated(object sender, DataTransferEventArgs e)
        {
            
        }
        //Evento del boton confirmar, para guardar cambios por las dudas
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {

            
            
            db.SaveChanges();
        }
        //Combobox de elegir curso, ahora si lo nombre bien
        private void CursoBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Curso cur = (Curso)cursoBox.SelectedItem;
            db.Cursos.Load();
            var dset = db.Cursos;
            DbSet<Curso> qry = dset;
            qry.Load();
            foreach (var item in dset)
            {
                if (item.CurDivision.Equals(cur.CurDivision))
                {
                    cur = item;
                }
            }

            alumnosGrid.Visibility = Visibility.Visible;
            alumnosGrid.ItemsSource = cur.alumnos;

            confirmButton.Visibility = Visibility.Visible;
        }
    }
}
