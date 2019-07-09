using GestionFacultad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
        //Contexto de la base de datos
        ProgramControl db;
        //Constructor, se instancia el contexto de la DB, y se agrega un evento al cerrarse la ventana
        public Window1(ProgramControl programControl)
        {
            db = programControl;
            InitializeComponent();
            DataContext = this;
            this.Closed += Window1_Closed;
        }
        //Guarda los cambios en la db
        private void Window1_Closed(object sender, EventArgs e)
        {
            db.SaveChanges();
            
        }

        private void Inscribir_Click(object sender, RoutedEventArgs e)
        {
            alumnoControl alcont = new alumnoControl();
            displayBox.Children.Add(alcont);
        }
    }
}
