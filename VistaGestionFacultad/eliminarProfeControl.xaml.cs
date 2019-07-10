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
    /// Interaction logic for eliminarProfeControl.xaml
    /// </summary>
    public partial class eliminarProfeControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public eliminarProfeControl()
        {
            InitializeComponent();
            var dset = db.Profes;
            DbSet<Profesor> qry = dset;
            qry.Load();
            profes.ItemsSource = dset.Local.ToBindingList();
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            var prof = profes.SelectedItem as Profesor;
            if (prof != null)
            {
                db.Profes.Remove(prof);
                MessageBox.Show("Se elimino correctamente");
                db.SaveChanges();
            }
        }
    }
}
