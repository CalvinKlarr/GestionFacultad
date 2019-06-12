using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ComboBoxItem[] items = new ComboBoxItem[20];



        
        
        public Window1()
        {
            
            InitializeComponent();
            
            items[0] = itemOne;
            items[1] = itemTwo;
            items[2] = itemThree;
            items[3] = itemFour;
            items[4] = itemFive;
            items[5] = itemSix;
            items[6] = itemSeven;
            items[7] = itemEight;
            items[8] = itemNine;
            items[9] = itemTen;
            items[10] = itemEleven;
            items[11] = itemTwelve;
            items[12] = itemThirteen;
            items[13] = itemFourteen;
            items[14] = itemFifteen;
            items[15] = itemSixteen;
            items[16] = itemSeventeen;
            items[17] = itemEightteen;
            items[18] = itemNineteen;
            items[19] = itemTwenty;

        }
        public void sendText(string text)
        {

        }

        private void AlumnosPorcurso_Click(object sender, RoutedEventArgs e)
        {
            elegirCursoTexto.Text = "Elija el curso del que desea ver los alumnos";
            legajoAlumno.Visibility = Visibility.Collapsed;
            confirmButton.Visibility = Visibility.Collapsed;
            elegirCursoTexto.Visibility = Visibility.Visible;
            elegirCurso.Visibility = Visibility.Visible;
            itemOne.Content = "Primer cuatrimestre - Mañana";
            itemTwo.Content = "Primer cuatrimestre - Tarde";
            itemThree.Content = "Primer cuatrimestre - Noche";
            itemFour.Content = "Segundo cuatrimestre - Mañana";
            itemFive.Content = "Segundo cuatrimestre - Tarde";
            itemSix.Content = "Segundo cuatrimestre - Noche";
            itemSeven.Content = "Tercer cuatrimestre - Noche";
            itemEight.Content = "Cuarto cuatrimestre - Noche";

            for (int i = 8; i < 20; i++)
            {
                items[i].Visibility = Visibility.Collapsed;
            }
            
            
            
            
        }

        private void ElegirCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }

        private void AlumnosPorMateria_Click(object sender, RoutedEventArgs e)
        {
            legajoAlumno.Visibility = Visibility.Collapsed;
            elegirCursoTexto.Visibility = Visibility.Visible;
            elegirCurso.Visibility = Visibility.Visible;
            confirmButton.Visibility = Visibility.Collapsed;
            for (int i = 9;i < 20; i++)
            {
                items[i].Visibility = Visibility.Visible;

            }
            elegirCursoTexto.Text = "Elija la materia de la que desea ver los alumnos";
            itemOne.Content = "Matematicas";
            itemTwo.Content = "Ingles I";
            itemThree.Content = "Sistema de procesamiento de datos";
            itemFour.Content = "Programacion I";
            itemFive.Content = "Laboratorio de Computacion I";
            itemSix.Content = "Estadistica";
            itemSeven.Content = "Ingles II";
            itemEight.Content = "Arquitectura y sistemas operativos";
            itemNine.Content = "Programacion II";
            itemTen.Content = "Laboratorio de Computacion II";
            itemEleven.Content = "Metodologia de la Investigacion";
            itemTwelve.Content = "Programacion III";
            itemThirteen.Content = "Laboratorio de Computacion III";
            itemFourteen.Content = "Organizacion Contable de la Empresa";
            itemFifteen.Content = "Organizacion Empresarial";
            itemSixteen.Content = "Legislacion";
            itemSeventeen.Content = "Diseño y administracion de base de datos";
            itemEightteen.Content = "Laboratorio de computacion IV";
            itemNineteen.Content = "Elementos de la investigacion operativa";
            itemTwenty.Content = "Metodologia de sistemas";


        }
        
        private void VerCalificaciones_Click(object sender, RoutedEventArgs e)
        {
            elegirCursoTexto.Text = "Ingrese el legajo del alumno para ver sus calificaciones";
            elegirCursoTexto.Visibility = Visibility.Visible;
            legajoAlumno.Visibility = Visibility.Visible;
            confirmButton.Visibility = Visibility.Visible;
            confirmButton.Content = "Aceptar";
            elegirCurso.Visibility = Visibility.Collapsed;
            
        }

        private void SubirCalificaciones_Click(object sender, RoutedEventArgs e)
        {
            elegirCursoTexto.Text = "Ingrese el legajo del alumno para actualizar sus calificaciones";
            elegirCursoTexto.Visibility = Visibility.Visible;
            legajoAlumno.Visibility = Visibility.Visible;
            confirmButton.Visibility = Visibility.Visible;
            confirmButton.Content = "Aceptar";
            elegirCurso.Visibility = Visibility.Collapsed;
        }

        private void BajaAlumno_Click(object sender, RoutedEventArgs e)
        {
            elegirCursoTexto.Text = "Ingrese el legajo del alumno para darlo de baja del sistema";
            elegirCursoTexto.Visibility = Visibility.Visible;
            legajoAlumno.Visibility = Visibility.Visible;
            confirmButton.Visibility = Visibility.Visible;
            confirmButton.Content = "Aceptar";
            elegirCurso.Visibility = Visibility.Collapsed;

        }

        private void ModificarAlumno_Click(object sender, RoutedEventArgs e)
        {
            elegirCursoTexto.Text = "Ingrese el legajo del alumno para actualizar su entrada en el sistema";
            elegirCursoTexto.Visibility = Visibility.Visible;
            legajoAlumno.Visibility = Visibility.Visible;
            confirmButton.Visibility = Visibility.Visible;
            confirmButton.Content = "Aceptar";
            elegirCurso.Visibility = Visibility.Collapsed;
        }
    }
}
