
using GestionFacultad;
using System.Windows;


namespace VistaGestionFacultad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow AppWindow;
        ProgramControl db;

        public MainWindow()
        {
            db = new ProgramControl();
            InitializeComponent();
            AppWindow = this;
            
        }

        private void AlumnoButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            db.Dispose();
            Close();
        }

        private void AsignaturasButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2(db);
            window2.Show();
        }

        private void ProfesorButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.SaveChanges();
            db.Dispose();
        }
    }
}
