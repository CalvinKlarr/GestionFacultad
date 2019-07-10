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
    /// Interaction logic for cursosControl.xaml
    /// </summary>
    public partial class cursosControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public cursosControl()
        {
            InitializeComponent();
            cursos.ItemsSource = db.Cursos.ToList();
        }

        private void Cursos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cur = cursos.SelectedItem as Curso;
            List<Alumno> alums = new List<Alumno>();
            int flag;
            if(cur != null)
            {
                foreach(var a in cur.alumnoID)
                {
                    if(int.TryParse(a,out flag))
                    {
                        foreach(var alu in db.Alumnos)
                        {
                            if(alu.Id == flag)
                            {
                                alums.Add(alu);
                            }
                        }
                    }
                }
            }

            verCursos.ItemsSource = alums;
        }
    }
}
