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
    /// Interaction logic for verProfesControl.xaml
    /// </summary>
    public partial class verProfesControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public verProfesControl()
        {
            InitializeComponent();
            var dset = db.Profes;
            DbSet<Profesor> qry = dset;
            qry.Load();
            ver.ItemsSource = dset.Local.ToBindingList();
        }
    }
}
