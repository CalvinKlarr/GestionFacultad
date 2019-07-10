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
    /// Interaction logic for agregarProfesControl.xaml
    /// </summary>
    public partial class agregarProfesControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        Profesor profe;
        public agregarProfesControl()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, RoutedEventArgs e)
        {
            profe = new Profesor();
            int flag;
            profe.Nombre = nombre.Text;
            profe.Apellido = apellido.Text;
            if(int.TryParse(dni.Text,out flag))
            {
                profe.Dni = flag;
            }
            else
            {
                MessageBox.Show("Ingrese un dni valido!");
            }
            if(int.TryParse(telefono.Text,out flag))
            {
                profe.Tel = flag;
            }
            profe.Direc = direccion.Text;

            db.Profes.Add(profe);
            db.SaveChanges();
            MessageBox.Show("Alta realizada con exito!");
        }
    }
}
