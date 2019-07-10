﻿using GestionFacultad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for modificarProfeControl.xaml
    /// </summary>
    public partial class modificarProfeControl : UserControl
    {
        ProgramControl db = new ProgramControl();
        public modificarProfeControl()
        {
            InitializeComponent();
            var dset = db.Profes;
            DbSet<Profesor> qry = dset;
            qry.Load();
            profes.ItemsSource = dset.Local.ToBindingList();
        }

        private void Profes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var profe = profes.SelectedItem as Profesor;
            if (profe != null)
            {
                modificarProfes modificarProfes = new modificarProfes(profe);
                modificarProfes.Show();
            }
        }
    }
}
