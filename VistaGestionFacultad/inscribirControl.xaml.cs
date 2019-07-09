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
    /// Interaction logic for inscribirControl.xaml
    /// </summary>
    public partial class inscribirControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        Alumno alum;
        public inscribirControl()
        {
            var dset = db.Alumnos;
            DbSet<Alumno> qry = dset;
            qry.Load();
            InitializeComponent();
            alumnos.ItemsSource = dset.Local.ToBindingList();
            
        }

        private void Asignaturas_DropDownOpened(object sender, EventArgs e)
        {
            if(alumnos.SelectedItem == null)
            {
                MessageBox.Show("Elija un alumno primero!");
            }
            else
            {
                alum = alumnos.SelectedItem as Alumno;
                if(alum != null)
                {
                    var dset = db.Asigns;
                    DbSet<Asignaturas> qry = dset;
                    qry.Load();
                    foreach(var a in dset.Local.ToList())
                    {
                        
                        if (a.correlativas.Intersect(alum.aprobadas).Count() == a.correlativas.Count())
                        {
                            asignaturas.Items.Add(a);
                        }


                    }

                }
            }

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if(asignaturas.SelectedItem != null)
            {
                var a = alumnos.SelectedItem as Alumno;
                if (a != null)
                {
                    var dset = db.Asigns;
                    DbSet<Asignaturas> qry = dset;
                    qry.Load();
                    foreach (var asi in dset.Local.ToList())
                    {
                        if(asi.Equals(asignaturas.SelectedItem as Asignaturas))
                        {
                            asi.inscriptos.Add(a);
                        }
                    }
                }
            }
        }
    }
}
