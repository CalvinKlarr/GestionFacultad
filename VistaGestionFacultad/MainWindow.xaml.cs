
using GestionFacultad;
using System;
using System.Collections.Generic;
using System.Linq;
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
            this.Closed += MainWindow_Closed;
            //ASIGNATURAS
            
            
            using (var dba = new ProgramControl())
            {
                bool isAsigEmpty = !dba.Asigns.Any();
                var a1 = new Aula();
                var a2 = new Aula();
                var a3 = new Aula();
                var a4 = new Aula();
                var a5 = new Aula();
                var a6 = new Aula();
                var a7 = new Aula();
                var a8 = new Aula();
                /*
                foreach(var al in dba.Alumnos)
                {
                    dba.Alumnos.Remove(al);
                }
                foreach (var asi in dba.Asigns)
                {
                    dba.Asigns.Remove(asi);
                }
                foreach (var au in dba.Aulas)
                {
                    dba.Aulas.Remove(au);
                }
                foreach (var cur in dba.Cursos)
                {
                    dba.Cursos.Remove(cur);
                }
                foreach (var prof in dba.Profes)
                {
                    dba.Profes.Remove(prof);
                }
                dba.SaveChanges();
                */

                if (isAsigEmpty)
                {
                    
                    

                    var a = new Asignaturas { Asign = "Arquitectura y Sistemas Operativos" };
                    List<string> corr = new List<string>();
                    corr.Add("Sistemas de Procesamiento de Datos");
                    a.correlativas = corr;
                    var b = new Asignaturas { Asign = "Estadistica" };
                    List<string> corr_estad = new List<string>();
                    corr_estad.Add("Matemáticas");
                    b.correlativas = corr_estad;
                    var c = new Asignaturas { Asign = "Inglés I" };
                    
                    var d = new Asignaturas { Asign = "Inglés II" };
                    List<string> corr_inglesII = new List<string>();
                    corr_inglesII.Add("Inglés I");
                    d.correlativas = corr_inglesII;
                    var e = new Asignaturas { Asign = "Laboratorio de Computación I" };
                    
                    var f = new Asignaturas { Asign = "Laboratorio de Computación II" };
                    List<string> corr_labii = new List<string>();
                    corr_labii.Add("Laboratorio de Computación I");
                    corr_labii.Add("Programación I");
                    f.correlativas = corr_labii;
                    var g = new Asignaturas { Asign = "Matemáticas" };
                    
                    var h = new Asignaturas { Asign = "Metodologia de la investigación" };
                    
                    var i = new Asignaturas { Asign = "Programación I" };
                    
                    var j = new Asignaturas { Asign = "Programación II" };
                    List<string> corr_progii = new List<string>();
                    corr_progii.Add("Laboratorio de Computación I");
                    corr_progii.Add("Programación I");
                    j.correlativas = corr_progii;
                    var k = new Asignaturas { Asign = "Sistemas de Procesamiento de Datos" };
                    
                    var l = new Asignaturas { Asign = "Laboratorio de Computación III" };
                    List<string> corr_labiii = new List<string>();
                    corr_labiii.Add("Laboratorio de Computación II");
                    corr_labiii.Add("Programación II");
                    l.correlativas = corr_labiii;
                    var m = new Asignaturas { Asign = "Organización Contable de la Empresa" };
                    List<string> corr_orgcont = new List<string>();
                    corr_orgcont.Add("Matemáticas");
                    m.correlativas = corr_orgcont;
                    var n = new Asignaturas { Asign = "Organización Empresarial" };
                    List<string> corr_orgemp = new List<string>();
                    corr_orgemp.Add("Estadistica");
                    n.correlativas = corr_orgemp;
                    var o = new Asignaturas { Asign = "Programación III" };
                    List<string> corr_progiii = new List<string>();
                    corr_progiii.Add("Laboratorio de Computación II");
                    corr_progiii.Add("Programación II");
                    o.correlativas = corr_progiii;
                    var p = new Asignaturas { Asign = "Elementos de Investigación operativa" };
                    List<string> corr_elem = new List<string>();
                    corr_elem.Add("Estadistica");
                    p.correlativas = corr_elem;
                    var q = new Asignaturas { Asign = "Legislación" };
                    
                    var r = new Asignaturas { Asign = "Diseño y Administración de Bases de Datos" };
                    List<string> corr_disAdmin = new List<string>();
                    corr_disAdmin.Add("Laboratorio de Computación III");
                    corr_disAdmin.Add("Programación III");
                    r.correlativas = corr_disAdmin;
                    var s = new Asignaturas { Asign = "Laboratorio de Computación IV" };
                    List<string> corr_labiv = new List<string>();
                    corr_labiv.Add("Laboratorio de Computación III");
                    corr_labiv.Add("Programación III");
                    s.correlativas = corr_labiv;
                    var t = new Asignaturas { Asign = "Metodologia de Sistemas" };
                    List<string> corr_metodSist = new List<string>();
                    corr_metodSist.Add("Laboratorio de Computación III");
                    corr_metodSist.Add("Programación III");
                    corr_metodSist.Add("Metodologia de la investigación");
                    corr_metodSist.Add("Organización Contable de la Empresa");
                    corr_metodSist.Add("Organización Empresarial");
                    t.correlativas = corr_metodSist;



                    dba.Asigns.Add(a);
                    dba.Asigns.Add(b);
                    dba.Asigns.Add(c);
                    dba.Asigns.Add(d);
                    dba.Asigns.Add(e);
                    dba.Asigns.Add(f);
                    dba.Asigns.Add(g);
                    dba.Asigns.Add(h);
                    dba.Asigns.Add(i);
                    dba.Asigns.Add(j);
                    dba.Asigns.Add(k);
                    dba.Asigns.Add(l);
                    dba.Asigns.Add(m);
                    dba.Asigns.Add(n);
                    dba.Asigns.Add(o);
                    dba.Asigns.Add(p);
                    dba.Asigns.Add(q);
                    dba.Asigns.Add(r);
                    dba.Asigns.Add(s);
                    dba.Asigns.Add(t);
                   
                    

                    dba.SaveChanges();

                }
                


                //AULAS y Cursos
                bool isCursosEmpty = !dba.Cursos.Any();
                bool isAulaEmpty = !dba.Aulas.Any();

                if (isAulaEmpty)
                {


                    

                    a1.Id = 0;
                    a1.Capacidad = 30;
                    a1.ConexionARed = true;
                    a1.Proyeccion = true;
                    a1.Aul = "1.1";

                    a2.Id = 0;
                    a2.Capacidad = 30;
                    a2.ConexionARed = true;
                    a2.Proyeccion = true;
                    a2.Aul = "1.2";

                    a3.Id = 0;
                    a3.Capacidad = 30;
                    a3.ConexionARed = true;
                    a3.Proyeccion = true;
                    a3.Aul = "1.3";

                    a4.Id = 0;
                    a4.Capacidad = 30;
                    a4.ConexionARed = true;
                    a4.Proyeccion = true;
                    a4.Aul = "2.1";

                    a5.Id = 0;
                    a5.Capacidad = 30;
                    a5.ConexionARed = true;
                    a5.Proyeccion = true;
                    a5.Aul = "2.2";

                    a6.Id = 0;
                    a6.Capacidad = 30;
                    a6.ConexionARed = true;
                    a6.Proyeccion = true;
                    a6.Aul = "2.3";

                    a7.Id = 0;
                    a7.Capacidad = 30;
                    a7.ConexionARed = true;
                    a7.Proyeccion = true;
                    a7.Aul = "1.4";

                    a8.Id = 0;
                    a8.Capacidad = 30;
                    a8.ConexionARed = true;
                    a8.Proyeccion = true;
                    a8.Aul = "1.5";

                    dba.Aulas.Add(a1);
                    dba.Aulas.Add(a2);
                    dba.Aulas.Add(a3);
                    dba.Aulas.Add(a4);
                    dba.Aulas.Add(a5);
                    dba.Aulas.Add(a6);
                    dba.Aulas.Add(a7);
                    dba.Aulas.Add(a8);
                    dba.SaveChanges();
                }

                if (isCursosEmpty) { 

                    //Cursos

                    var c1 = new Curso();
                    var c2 = new Curso();
                    var c3 = new Curso();
                    var c4 = new Curso();
                    var c5 = new Curso();
                    var c6 = new Curso();
                    var c7 = new Curso();
                    var c8 = new Curso();
                    var c9 = new Curso();
                    var c10 = new Curso();
                    var c11 = new Curso();
                    var c12 = new Curso();

                    c1.Cur = "1er Cuatrimestre";
                    c1.Division = "Turno Mañana";
                    c1.aula = a1;
                    c2.Cur = "2do Cuatrimestre";
                    c2.Division = "Turno Mañana";
                    c2.aula = a2;
                    c3.Cur = "3ro Cuatrimestre";
                    c3.Division = "Turno Mañana";
                    c3.aula = a3;
                    c4.Cur = "4to Cuatrimestre";
                    c4.Division = "Turno Mañana";
                    c4.aula = a4;

                    c5.Cur = "1er Cuatrimestre";
                    c5.Division = "Turno Tarde";
                    c5.aula = a5;
                    c6.Cur = "2do Cuatrimestre";
                    c6.Division = "Turno Tarde";
                    c6.aula = a6;
                    c7.Cur = "3ro Cuatrimestre";
                    c7.Division = "Turno Tarde";
                    c7.aula = a7;
                    c8.Cur = "4to Cuatrimestre";
                    c8.Division = "Turno Tarde";
                    c8.aula = a8;

                    c9.Cur = "1er Cuatrimestre";
                    c9.Division = "Turno Noche";
                    c9.aula = a1;
                    c10.Cur = "2do Cuatrimestre";
                    c10.Division = "Turno Noche";
                    c10.aula = a2;
                    c11.Cur = "3ro Cuatrimestre";
                    c11.Division = "Turno Noche";
                    c11.aula = a3;
                    c12.Cur = "4to Cuatrimestre";
                    c12.Division = "Turno Noche";
                    c12.aula = a4;

                    dba.Cursos.Add(c1);
                    dba.Cursos.Add(c2);
                    dba.Cursos.Add(c3);
                    dba.Cursos.Add(c4);
                    dba.Cursos.Add(c5);
                    dba.Cursos.Add(c6);
                    dba.Cursos.Add(c7);
                    dba.Cursos.Add(c8);
                    dba.Cursos.Add(c9);
                    dba.Cursos.Add(c10);
                    dba.Cursos.Add(c11);
                    dba.Cursos.Add(c12);
                    dba.SaveChanges();



                }
                
                bool isProfesEmpty = !dba.Profes.Any();
                if (isProfesEmpty)
                {

                    // PROFES
                    List<string> materias = new List<string>();

                    var p1 = new Profesor("Reed", "Richards", 20151314, 610026, "Av 9 de Julio 360", materias);
                    var p2 = new Profesor("Hank", "Pym", 21151520, 610006, "Av Wilde 564", materias);
                    var p3 = new Profesor("Charles", "Xavier", 20789123, 620326, "José Hernandez 669", materias);
                    var p4 = new Profesor("Bruce", "Banner", 20543542, 710026, " Arturo Illia 420", materias);
                    var p5 = new Profesor("Anthony", "Stark", 22426814, 410426, "Calle Malibu 142", materias);
                    var p6 = new Profesor("Stephen", "Strange", 23151360, 513426, "Av Alberdi 616", materias);
                    var p7 = new Profesor("Peter", "Parker", 25760750, 600026, "H. Yrigoyen 442", materias);
                    var p8 = new Profesor("Bill", "Foster", 20151314, 610026, "Frondizi 365", materias);
                    var p9 = new Profesor("Steve", "Rogers", 10236250, 610026, "Entre Rios 942", materias);
                    var p10 = new Profesor("Hank", "McCoy", 24740650, 610026, "José Hernandez 669", materias);

                    dba.Profes.Add(p1);
                    dba.Profes.Add(p2);
                    dba.Profes.Add(p3);
                    dba.Profes.Add(p4);
                    dba.Profes.Add(p5);
                    dba.Profes.Add(p6);
                    dba.Profes.Add(p7);
                    dba.Profes.Add(p8);
                    dba.Profes.Add(p9);
                    dba.Profes.Add(p10);
                    dba.SaveChanges();

                }
                


                bool isAlumnosEmpty = !dba.Alumnos.Any();
                if (isAlumnosEmpty)
                {

                    //ALUMNOS

                    var alum1 = new Alumno("Peter Benjamin", "Parker", 41560550, 710026, "H. Yrigoyen 425");
                    var alum2 = new Alumno("Lukas", "Cage", 41660550, 543419, "Catamarca 225");
                    var alum3 = new Alumno("Benjamin", "Reilly", 41560750, 526681, "Mitre 145");
                    var alum4 = new Alumno("Miles", "Morales", 42560850, 712236, "Formosa 369");
                    var alum5 = new Alumno("Calvo", "Calvin", 41560452, 241267, "Liniers 749");
                    var alum6 = new Alumno("Ben", "Tennyson", 41572050, 900739, "Av Lavalle 752");
                    var alum7 = new Alumno("Gwen", "Tennyson", 41560820, 510783, "Av Lavalle 750");
                    var alum8 = new Alumno("Mary Jane", "Watson", 41460850, 164373, "Cervantes 105");
                    var alum9 = new Alumno("Harry", "Osborn", 40960550, 658669, "Av. Sarmiento 457");
                    var alum10 = new Alumno("Eugene", "Thompson", 39966950, 687933, "Carlos Pellegrini 862");
                    var alum11 = new Alumno("Liz", "Allan", 41580740, 164371, "Av San Martin 372");
                    var alum12 = new Alumno("Eddie", "Brock", 39560852, 094858, "Arturo Illia 744");
                    var alum13 = new Alumno("Josias", "Urutti", 41760750, 610026, "H. Yrigoyen 442");
                    var alum14 = new Alumno("Niko", "Bellic", 40420420, 659989, "Av. Laprida 699");
                    var alum15 = new Alumno("Carl", "Johnson", 40696969, 771267, "Colón 425");


                    dba.Alumnos.Add(alum1);
                    dba.Alumnos.Add(alum2);
                    dba.Alumnos.Add(alum3);
                    dba.Alumnos.Add(alum4);
                    dba.Alumnos.Add(alum5);
                    dba.Alumnos.Add(alum6);
                    dba.Alumnos.Add(alum7);
                    dba.Alumnos.Add(alum8);
                    dba.Alumnos.Add(alum9);
                    dba.Alumnos.Add(alum10);
                    dba.Alumnos.Add(alum11);
                    dba.Alumnos.Add(alum12);
                    dba.Alumnos.Add(alum13);
                    dba.Alumnos.Add(alum14);
                    dba.Alumnos.Add(alum15);
                    dba.SaveChanges();

                }
                



            }

            




        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            db.Dispose();
        }

        private void AlumnoButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1(db);
            window1.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            
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
        
    }
}
