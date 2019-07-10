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
    /// Interaction logic for modificarProfes.xaml
    /// </summary>
    public partial class modificarProfes : Window
    {
        ProgramControl db = new ProgramControl();
        Profesor profe;
        public modificarProfes(Profesor prof)
        {
            InitializeComponent();
            profe = prof;
            var dset = db.Asigns;
            DbSet<Asignaturas> qry = dset;
            qry.Load();
            materiasAgregar.ItemsSource = dset.Local.ToBindingList();
            materias.ItemsSource = profe.materias.ToList();
            nombre.Text = profe.Nombre;
            apellido.Text = profe.Apellido;
            dni.Text = profe.Dni.ToString();
            telefono.Text = profe.Tel.ToString();
            direccion.Text = profe.Direc;
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            var asignatura = materiasAgregar.SelectedItem as Asignaturas;

            if(asignatura != null) {
                profe.materias.Add(asignatura.Asign);
                materias.ItemsSource = profe.materias.ToList();
            }
        }

        private void Quitar_Click(object sender, RoutedEventArgs e)
        {
            var mat = materias.SelectedItem as string;
            if (mat != null)
            {
                profe.materias.Remove(mat);
                materias.ItemsSource = profe.materias.ToList();
            }

        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            var pro = db.Profes.FirstOrDefault(p => p.Dni == profe.Dni);
            List<string> materiasagregar = new List<string>();
            int flag;
            pro.Nombre = nombre.Text;
            pro.Apellido = apellido.Text;
            if(int.TryParse(dni.Text,out flag))
            {
                pro.Dni = flag;
            }
            if(int.TryParse(telefono.Text,out flag))
            {
                pro.Tel = flag;
            }
            pro.Direc = direccion.Text;
            foreach(var m in materias.Items){
                var item = m as string;
                if (item != null)
                {
                    materiasagregar.Add(item);
                }
            }
            pro.materias = materiasagregar;

            db.SaveChanges();
            MessageBox.Show("Modificacion realizada");
            this.Close();
        }
    }
}
