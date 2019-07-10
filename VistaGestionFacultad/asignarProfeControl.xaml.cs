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
    /// Interaction logic for asignarProfeControl.xaml
    /// </summary>
    public partial class asignarProfeControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public asignarProfeControl()
        {
            InitializeComponent();
            var dset = db.Profes;
            DbSet<Profesor> qry = dset;
            qry.Load();
            profes.ItemsSource = dset.Local.ToBindingList();
            var dbset = db.Asigns;
            DbSet<Asignaturas> query = dbset;
            query.Load();
            materias.ItemsSource = dbset.Local.ToBindingList();

        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            var profesel = profes.SelectedItem as Profesor;
            var materia = materias.SelectedItem as Asignaturas;
            bool flag = true;
            

            if (profesel != null)
            {
                foreach (var m in profesel.materias)
                {
                    if(m == materia.Asign)
                    {
                        MessageBox.Show("Esa materia ya esta asignada.");
                        flag = false;
                    }
                }
                

                if (materia != null && flag)
                {
                    Profesor profe = db.Profes.FirstOrDefault(p => p.Dni == profesel.Dni);
                    profe.materias.Add(materia.Asign);
                    db.SaveChanges();
                    MessageBox.Show("Materia asignada");
                }
            }

        }
    }
}
