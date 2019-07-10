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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VistaGestionFacultad
{
    /// <summary>
    /// Interaction logic for alumnoControl.xaml
    /// </summary>
    public partial class alumnoControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public Alumno alum;
        public alumnoControl()
        {
            InitializeComponent();
            
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            string nom, ap, direcc;
            int dn, tel;
            int testint;
            
            if(nombre.Text == "Ingrese su nombre aqui.." || int.TryParse(nombre.Text, out testint))
            {
                MessageBox.Show("Ingrese un nombre valido!");
            }
            if (apellido.Text == "Ingrese su apellido aqui.." || int.TryParse(apellido.Text, out testint))
            {
                MessageBox.Show("Ingrese un apellido valido!");
            }
            if (dni.Text == "Ingrese su DNI aqui.." || !int.TryParse(dni.Text, out testint))
            {
                MessageBox.Show("Ingrese un DNI valido!");
            }
            if (telefono.Text == "Ingrese su telefono aqui.." || !int.TryParse(telefono.Text, out testint))
            {
                MessageBox.Show("Ingrese un telefono valido!");
            }
            if (direccion.Text == "Ingrese su direccion aqui.." || int.TryParse(direccion.Text, out testint))
            {
                MessageBox.Show("Ingrese una direccion valido!");
            }

            else
            {
                nom = nombre.Text;
                ap = apellido.Text;
                dn = int.Parse(dni.Text);
                tel = int.Parse(telefono.Text);
                direcc = direccion.Text;
                alum = new Alumno(nom, ap, dn, tel, direcc);
                db.Alumnos.Add(alum);
                db.SaveChanges();
                MessageBox.Show("Alta realizada con exito!");
            }
            
        }
    }
}
