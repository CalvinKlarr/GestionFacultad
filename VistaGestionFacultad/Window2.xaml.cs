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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ComboBoxItem[] items = new ComboBoxItem[20];
        public Window2()
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

        private void InscribirAsignatura_Click(object sender, RoutedEventArgs e)
        {
            elegirAsignaturaTexto.Text = "Elija la asignatura a la que desea inscribirse";
            elegirAsignaturaTexto.Visibility = Visibility.Visible;
            elegirAsignatura.Visibility = Visibility.Visible;
            for (int i = 8; i < 20; i++)
            {
                items[i].Visibility = Visibility.Visible;
            }
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

        private void ElegirCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void VerAulas_Click(object sender, RoutedEventArgs e)
        {
            elegirAsignaturaTexto.Text = "Elija el aula";
            for (int i = 8; i < 20; i++)
            {
                items[i].Visibility = Visibility.Collapsed;
            }
            itemOne.Content = "Aula 1.1";
            itemTwo.Content = "Aula 1.2";
            itemThree.Content = "Aula 1.3";
            itemFour.Content = "Aula 2.1";
            itemFive.Content = "Aula 2.2";
            itemSix.Content = "Aula 2.3";
            itemSeven.Content = "Aula 1.4";
            itemEight.Content = "Aula 1.5";
        }
    }
}
