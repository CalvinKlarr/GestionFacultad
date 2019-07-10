using GestionFacultad;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for modifyAlumnos.xaml
    /// </summary>
    public partial class modifyAlumnos : Window
    {
        ProgramControl db = new ProgramControl();
        Alumno alum;
        public modifyAlumnos(Alumno a)
        {
            InitializeComponent();
            alum = a;
            nombre.Text = alum.Nombre;
            apellido.Text = alum.Apellido;
            dni.Text = alum.Dni.ToString();
            telefono.Text = alum.Tel.ToString();
            direccion.Text = alum.Direc;

            materias.ItemsSource = alum.aprobadas.ToList();
            opciones.ItemsSource = db.Asigns.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var asig = opciones.SelectedItem as Asignaturas;
            if (asig != null)
            {
                alum.aprobadas.Add(asig.Asign);
                materias.ItemsSource = alum.aprobadas.ToList();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var asig = materias.SelectedItem as string;
            if (asig != null)
            {
                alum.aprobadas.Remove(asig);
                materias.ItemsSource = alum.aprobadas.ToList();
            }
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            int flag;
            List<string> materiasagregar = new List<string>();
            alum.Nombre = nombre.Text;
            alum.Apellido = apellido.Text;
            if(int.TryParse(dni.Text,out flag))
            {
                alum.Dni = flag;
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido!");
            }
            if(int.TryParse(telefono.Text,out flag))
            {
                alum.Tel = flag;
            }
            else
            {
                MessageBox.Show("Ingrese un telefono valido!");
            }
            alum.Direc = direccion.Text;
            foreach(var item in materias.Items)
            {
                var m = item as string;
                if (m != null)
                {
                    materiasagregar.Add(m);
                }
            }
            alum.aprobadas = materiasagregar;
            MessageBox.Show("Modificacion realizada!");

            var al = db.Alumnos.SingleOrDefault(aasd => aasd.Id == alum.Id );
            al.Nombre = alum.Nombre;
            al.Apellido = alum.Apellido;
            al.Dni = alum.Dni;
            al.Tel = alum.Tel;
            al.Direc = alum.Direc;
            al.aprobadas = alum.aprobadas;
            db.SaveChanges();

        }
    }
}
