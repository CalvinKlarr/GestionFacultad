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
    /// Interaction logic for asignaturasControl.xaml
    /// </summary>
    public partial class asignaturasControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public asignaturasControl()
        {
            
            InitializeComponent();

            asignaturas.ItemsSource = db.Asigns.ToList();
        }

        private void Asignaturas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Alumno> alumnos = new List<Alumno>();

            var asig = asignaturas.SelectedItem as Asignaturas;
            int flag;

            if(asig != null)
            {
                foreach (var a in asig.inscriptos)
                {
                    foreach(var alu in db.Alumnos)
                    {
                        if (int.TryParse(a, out flag))
                        {
                            if (alu.Id == flag)
                            {
                                alumnos.Add(alu);
                            }
                        }
                    }
                }

                verAsignaturas.ItemsSource = alumnos;
            }

        }
    }
}
