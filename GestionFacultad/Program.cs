using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using VistaGestionFacultad;


namespace GestionFacultad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();  */

            //ASIGNATURAS

            using (var db = new ProgramControl())
            {
                bool isAsigEmpty = !db.Asigns.Any();

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



                    db.Asigns.Add(a);
                    db.Asigns.Add(b);
                    db.Asigns.Add(c);
                    db.Asigns.Add(d);
                    db.Asigns.Add(e);
                    db.Asigns.Add(f);
                    db.Asigns.Add(g);
                    db.Asigns.Add(h);
                    db.Asigns.Add(i);
                    db.Asigns.Add(j);
                    db.Asigns.Add(k);
                    db.Asigns.Add(l);
                    db.Asigns.Add(m);
                    db.Asigns.Add(n);
                    db.Asigns.Add(o);
                    db.Asigns.Add(p);
                    db.Asigns.Add(q);
                    db.Asigns.Add(r);
                    db.Asigns.Add(s);
                    db.Asigns.Add(t);


                    db.SaveChanges();

                }
                else
                {

                    var query = from dick in db.Asigns
                                orderby dick.Asign
                                select dick;

                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Asign);

                    }


                }


                //AULAS y Cursos
                bool isCursosEmpty = !db.Cursos.Any();
                bool isAulaEmpty = !db.Aulas.Any();

               if (isAulaEmpty & isCursosEmpty)
               {


                    var a1 = new Aula();
                    var a2 = new Aula();
                    var a3 = new Aula();
                    var a4 = new Aula();
                    var a5 = new Aula();
                    var a6 = new Aula();
                    var a7 = new Aula();
                    var a8 = new Aula();

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

                    db.Aulas.Add(a1);
                    db.Aulas.Add(a2);
                    db.Aulas.Add(a3);
                    db.Aulas.Add(a4);
                    db.Aulas.Add(a5);
                    db.Aulas.Add(a6);
                    db.Aulas.Add(a7);
                    db.Aulas.Add(a8);
                    db.SaveChanges();



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
                    c1.asignaturas.Add("Inglés I");
                    c1.asignaturas.Add("Laboratorio de Computación I");
                    c1.asignaturas.Add("Matemáticas");
                    c1.asignaturas.Add("Programación I");
                    c1.asignaturas.Add("Sistemas de Procesamiento de Datos");


                    c2.Cur = "2do Cuatrimestre";
                    c2.Division = "Turno Mañana";
                    c2.aula = a2;
                    c2.asignaturas.Add("Arquitectura y Sistemas Operativos");
                    c2.asignaturas.Add("Estadística");
                    c2.asignaturas.Add("Inglés II");
                    c2.asignaturas.Add("Laboratorio de Computación II");
                    c2.asignaturas.Add("Metodología de la Investigación");
                    c2.asignaturas.Add("Programación II");


                    c3.Cur = "3ro Cuatrimestre";
                    c3.Division = "Turno Mañana";
                    c3.aula = a3;
                    c3.asignaturas.Add("Organización Empresarial");
                    c3.asignaturas.Add("Organización Contable de la Empresa");
                    c3.asignaturas.Add("Laboratorio de Computación III");
                    c3.asignaturas.Add("Programación III");
                    c3.asignaturas.Add("Legislación");


                    c4.Cur = "4to Cuatrimestre";
                    c4.Division = "Turno Mañana";
                    c4.aula = a4;
                    c4.asignaturas.Add("Elementos de Investigación Operativa");
                    c4.asignaturas.Add("Diseño y Administración de Bases de Datos");
                    c4.asignaturas.Add("Laboratorio de Computación IV");
                    c4.asignaturas.Add("Metodología de Sistemas I");

                    c5.Cur = "1er Cuatrimestre";
                    c5.Division = "Turno Tarde";
                    c5.aula = a5;
                    c5.asignaturas.Add("Inglés I");
                    c5.asignaturas.Add("Laboratorio de Computación I");
                    c5.asignaturas.Add("Matemáticas");
                    c5.asignaturas.Add("Programación I");
                    c5.asignaturas.Add("Sistemas de Procesamiento de Datos");


                    c6.Cur = "2do Cuatrimestre";
                    c6.Division = "Turno Tarde";
                    c6.aula = a6;
                    c6.asignaturas.Add("Arquitectura y Sistemas Operativos");
                    c6.asignaturas.Add("Estadística");
                    c6.asignaturas.Add("Inglés II");
                    c6.asignaturas.Add("Laboratorio de Computación II");
                    c6.asignaturas.Add("Metodología de la Investigación");
                    c6.asignaturas.Add("Programación II");

                    c7.Cur = "3ro Cuatrimestre";
                    c7.Division = "Turno Tarde";
                    c7.aula = a7;
                    c7.asignaturas.Add("Organización Empresarial");
                    c7.asignaturas.Add("Organización Contable de la Empresa");
                    c7.asignaturas.Add("Laboratorio de Computación III");
                    c7.asignaturas.Add("Programación III");
                    c7.asignaturas.Add("Legislación");

                    c8.Cur = "4to Cuatrimestre";
                    c8.Division = "Turno Tarde";
                    c8.aula = a8;
                    c8.asignaturas.Add("Elementos de Investigación Operativa");
                    c8.asignaturas.Add("Diseño y Administración de Bases de Datos");
                    c8.asignaturas.Add("Laboratorio de Computación IV");
                    c8.asignaturas.Add("Metodología de Sistemas I");


                    c9.Cur = "1er Cuatrimestre";
                    c9.Division = "Turno Noche";
                    c9.aula = a1;
                    c9.asignaturas.Add("Inglés I");
                    c9.asignaturas.Add("Laboratorio de Computación I");
                    c9.asignaturas.Add("Matemáticas");
                    c9.asignaturas.Add("Programación I");
                    c9.asignaturas.Add("Sistemas de Procesamiento de Datos");

                    c10.Cur = "2do Cuatrimestre";
                    c10.Division = "Turno Noche";
                    c10.aula = a2;
                    c10.asignaturas.Add("Arquitectura y Sistemas Operativos");
                    c10.asignaturas.Add("Estadística");
                    c10.asignaturas.Add("Inglés II");
                    c10.asignaturas.Add("Laboratorio de Computación II");
                    c10.asignaturas.Add("Metodología de la Investigación");
                    c10.asignaturas.Add("Programación II");

                    c11.Cur = "3ro Cuatrimestre";
                    c11.Division = "Turno Noche";
                    c11.aula = a3;
                    c11.asignaturas.Add("Organización Empresarial");
                    c11.asignaturas.Add("Organización Contable de la Empresa");
                    c11.asignaturas.Add("Laboratorio de Computación III");
                    c11.asignaturas.Add("Programación III");
                    c11.asignaturas.Add("Legislación");

                    c12.Cur = "4to Cuatrimestre";
                    c12.Division = "Turno Noche";
                    c12.aula = a4;
                    c12.asignaturas.Add("Elementos de Investigación Operativa");
                    c12.asignaturas.Add("Diseño y Administración de Bases de Datos");
                    c12.asignaturas.Add("Laboratorio de Computación IV");
                    c12.asignaturas.Add("Metodología de Sistemas I");


                    db.Cursos.Add(c1);
                    db.Cursos.Add(c2);
                    db.Cursos.Add(c3);
                    db.Cursos.Add(c4);
                    db.Cursos.Add(c5);
                    db.Cursos.Add(c6);
                    db.Cursos.Add(c7);
                    db.Cursos.Add(c8);
                    db.Cursos.Add(c9);
                    db.Cursos.Add(c10);
                    db.Cursos.Add(c11);
                    db.Cursos.Add(c12);
                    db.SaveChanges();



                }
                else
                {

                    var queryy = from aul in db.Aulas
                                 orderby aul.Id
                                 select aul;
                    foreach (var item in queryy)
                    {
                        Console.WriteLine(item.ToString());
                    }

                }
                bool isProfesEmpty = !db.Profes.Any();
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
                    //var p11= new Profesor()

                    db.Profes.Add(p1);
                    db.Profes.Add(p2);
                    db.Profes.Add(p3);
                    db.Profes.Add(p4);
                    db.Profes.Add(p5);
                    db.Profes.Add(p6);
                    db.Profes.Add(p7);
                    db.Profes.Add(p8);
                    db.Profes.Add(p9);
                    db.Profes.Add(p10);
                    db.SaveChanges();

                } else
                {
                    var queryProfes = from dicks in db.Profes
                                orderby dicks.Nombre
                                select dicks;

                    foreach (var item in queryProfes)
                    {
                        Console.WriteLine(item.Nombre+", "+ item.Apellido);

                    }
                }


                bool isAlumnosEmpty = !db.Alumnos.Any();
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


                    db.Alumnos.Add(alum1);
                    db.Alumnos.Add(alum2);
                    db.Alumnos.Add(alum3);
                    db.Alumnos.Add(alum4);
                    db.Alumnos.Add(alum5);
                    db.Alumnos.Add(alum6);
                    db.Alumnos.Add(alum7);
                    db.Alumnos.Add(alum8);
                    db.Alumnos.Add(alum9);
                    db.Alumnos.Add(alum10);
                    db.Alumnos.Add(alum11);
                    db.Alumnos.Add(alum12);
                    db.Alumnos.Add(alum13);
                    db.Alumnos.Add(alum14);
                    db.Alumnos.Add(alum15);
                    db.SaveChanges();

                }
                else
                {
                    var queryAlumnos = from bois in db.Profes
                                      orderby bois.Nombre
                                      select bois;

                    foreach (var item in queryAlumnos)
                    {
                        Console.WriteLine(item.Nombre + ", " + item.Apellido);

                    }
                }



            }

            Console.ReadKey();
            Console.WriteLine("Press any key to exit...");




        }
    }
}






/* _______████████_____██████
_________█░░░░░░░░██_██░░░░░░█
________█░░░░░░░░░░░█░░░░░░░░░█
_______█░░░░░░░███░░░█░░░░░░░░░█
_______█░░░░███░░░███░█░░░████░█
______█░░░██░░░░░░░░███░██░░░░██
_____█░░░░░░░░░░░░░░░░░█░░░░░░░░███
____█░░░░░░░░░░░░░██████░░░░░████░░█
____█░░░░░░░░░█████░░░████░░██░░██░░█
___██░░░░░░░███░░░░░░░░░░█░░░░░░░░███
__█░░░░░░░░░░░░░░█████████░░█████████
_█░░░░░░░░░░█████_████___████_█████___
_█░░░░░░░░░░█____█_███__█_____███_█___
█░░░░░░░░░░░░█___████_████____██_████
░░░░░░░░░░░░░█████████░░░████████░░░█
░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░░░░░░█
░░░░░░░░░░░░░░░░░░░░██░░░░█░░░░░░██
░░░░░░░░░░░░░░░░░░██░░░░░░░███████
░░░░░░░░░░░░░░░░██░░░░░░░░░░█░░░░░█
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█
░░░░░░░░░░░█████████░░░░░░░░░░░░░░██
░░░░░░░░░░█▒▒▒▒▒▒▒▒███████████████▒▒█
░░░░░░░░░█▒▒███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
░░░░░░░░░█▒▒▒▒▒▒▒▒▒█████████████████
░░░░░░░░░░████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
░░░░░░░░░░░░░░░░░░██████████████████
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█
██░░░░░░░░░░░░░░░░░░░░░░░░░░░██
▓██░░░░░░░░░░░░░░░░░░░░░░░░██
▓▓▓███░░░░░░░░░░░░░░░░░░░░█
▓▓▓▓▓▓███░░░░░░░░░░░░░░░██
▓▓▓▓▓▓▓▓▓███████████████▓▓█
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█  */
