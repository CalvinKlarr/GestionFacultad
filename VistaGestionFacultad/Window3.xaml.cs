﻿using System;
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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        ComboBoxItem[] items = new ComboBoxItem[20];
        public Window3()
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

        private void Profesores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void VerProfesores_Click(object sender, RoutedEventArgs e)
        {
            elegirProfesor.Text = "Elija la asignatura de la que desea ver los profesores";
            elegirProfesor.Visibility = Visibility.Visible;
            profesores.Visibility = Visibility.Visible;
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

        private void BajaProfesor_Click(object sender, RoutedEventArgs e)
        {
            elegirProfesor.Text = "Elija la asignatura para dar de baja el profesor";
            elegirProfesor.Visibility = Visibility.Visible;
            profesores.Visibility = Visibility.Visible;
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

        private void ModificarProfesor_Click(object sender, RoutedEventArgs e)
        {
            elegirProfesor.Text = "Elija la asignatura para modificar la entrada del profesor";
            elegirProfesor.Visibility = Visibility.Visible;
            profesores.Visibility = Visibility.Visible;
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
    }
}
