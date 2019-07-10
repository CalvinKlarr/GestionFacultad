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
            

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if(asignaturas.SelectedItem != null)
            {
                var a = alumnos.SelectedItem as Alumno;
                var asigna = asignaturas.SelectedItem as Asignaturas;
                if (a != null)
                {
                    var dset = db.Asigns;
                    DbSet<Asignaturas> qry = dset;
                    qry.Load();
                    foreach (var asi in dset.Local.ToList())
                    {
                        if(asi.Equals(asigna))
                        {
                            asi.inscriptos.Add(a.Id.ToString());
                        }
                    }
                    var ds = db.Cursos;
                    DbSet<Curso> qr = ds;
                    qr.Load();
                    foreach(var cur in ds.Local.ToList())
                    {
                        foreach(var asig in cur.asignaturas)
                        {
                            if(asig == asigna.Asign)
                            {
                                cur.alumnoID.Add(a.Id.ToString());
                            }
                        }
                    }

                    MessageBox.Show("Inscripcion realizada!");
                    db.SaveChanges();

                }
            }
        }

        

        private void Alumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool continueflag = false;
            asignaturas.Items.Clear(); 
            alum = alumnos.SelectedItem as Alumno;
            if (alum != null)
            {
                
                foreach (var a in db.Asigns)
                {
                    var flag = a.correlativas.Intersect(alum.aprobadas).Count() == a.correlativas.Count();
                    foreach(var ap in alum.aprobadas)
                    {
                        if(ap == a.Asign)
                        {
                            continueflag = true;
                        }
                        else
                        {
                            continueflag = false;
                        }
                    }
                    if (!continueflag)
                    {
                        if (a.correlativas.First() == "" || flag)
                        {
                            asignaturas.Items.Add(a);
                        }
                    }
                    

                    

                }

            }

        }
    }
}
