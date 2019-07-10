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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VistaGestionFacultad
{
    /// <summary>
    /// Interaction logic for deleteControl.xaml
    /// </summary>
    public partial class deleteControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public deleteControl()
        {
            InitializeComponent();
            var dset = db.Alumnos;
            DbSet<Alumno> qry = dset;
            qry.Load();
            alumnos.ItemsSource = dset.Local.ToBindingList();
        }

        private void Borrar_Click(object sender, RoutedEventArgs e)
        {
            var alum = alumnos.SelectedItem as Alumno;
            if(alum == null)
            {
                MessageBox.Show("Seleccione un alumno primero!");
            }
            else
            {
                db.Alumnos.Remove(alum);
                db.SaveChanges();
                MessageBox.Show("Se ha eliminado el alumno");
            }
        }
    }
}
