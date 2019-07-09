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
    /// Interaction logic for viewAlumnoControl.xaml
    /// </summary>
    public partial class viewAlumnoControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public viewAlumnoControl()
        {
            
            InitializeComponent();
            var dbset = db.Alumnos;
            DbSet<Alumno> qry = dbset;
            qry.Load();
            viewalumnos.ItemsSource = dbset.Local.ToBindingList();
        }
    }
}
