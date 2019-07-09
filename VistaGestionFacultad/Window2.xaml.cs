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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        ProgramControl db;
        public Window2(ProgramControl programControl)
        {
            db = programControl;
            this.Closed += Window2_Closed;
            InitializeComponent();
            
        }
        //Guardar cambios al cerrar, aunque ahora es readonly, era mas para editar en un principio
        private void Window2_Closed(object sender, EventArgs e)
        {
            db.SaveChanges();
            
        }
        //Unused
        private void InscribirAsignatura_Click(object sender, RoutedEventArgs e)
        {
            
        }
        //Unused
        private void ElegirCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //Evento al hacer click en ver aulas
        private void VerAulas_Click(object sender, RoutedEventArgs e)
        {
            elegirAsignatura.Visibility = Visibility.Collapsed;
            elegirAsignaturaTexto.Visibility = Visibility.Collapsed;
            elegirAula.Visibility = Visibility.Visible;
            var dbset = db.Aulas;
            DbSet<Aula> qry = dbset;
            qry.Load();
            elegirAula.ItemsSource = dbset.Local.ToBindingList();
        }
        //Unused
        private void ElegirAula_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
