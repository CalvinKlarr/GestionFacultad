using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistaGestionFacultad;


namespace GestionFacultad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*test
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();  */

            //ASIGNATURAS

            using (var db = new ProgramControl())
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

                var query = from dick in db.Asigns
                            orderby dick.Asign
                            select dick;

                foreach (var item in query)
                {
                    Console.WriteLine(item.Asign);
                   
                }


                //AULAS 

                using (var dbAula = new ProgramControl())
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

                    var queryy = from aul in db.Aulas
                                orderby aul.Id
                                select aul;
                    foreach (var item in queryy)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.ReadKey();


                    // lo q SIGUE


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
