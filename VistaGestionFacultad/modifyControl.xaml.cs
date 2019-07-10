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
    /// Interaction logic for modifyControl.xaml
    /// </summary>
    public partial class modifyControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public modifyControl()
        {
            InitializeComponent();
            var dset = db.Alumnos;
            DbSet<Alumno> qry = dset;
            qry.Load();


            alumnos.ItemsSource = dset.Local.ToBindingList();
        }

        private void Alumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var alum = alumnos.SelectedItem as Alumno;
            if(alum != null)
            {
                modifyAlumnos ma = new modifyAlumnos(alum);

                ma.Show();
            }
        }
    }
}
