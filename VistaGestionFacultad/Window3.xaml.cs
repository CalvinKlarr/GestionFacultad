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

        private void Profesores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //Evento al hacer click en ver profesores
        private void VerProfesores_Click(object sender, RoutedEventArgs e)
        {
            profesoresGrid.Visibility = Visibility.Visible;
            var dset = db.Profes;
            DbSet<Profesor> qry = dset;
            qry.Load();
            profesoresGrid.ItemsSource = dset.Local.ToBindingList();
            
        }
        //Unused
        private void BajaProfesor_Click(object sender, RoutedEventArgs e)
        {
            

        }
        //Unused
        private void ModificarProfesor_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
