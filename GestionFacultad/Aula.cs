using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionFacultad
{
    public class Aula
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private int capacidad;
        public int Capacidad { get { return capacidad; } set { capacidad = value; } }
        private bool conexionARed;
        public bool ConexionARed { get { return conexionARed; } set { conexionARed = value; } }
        private bool proyeccion;
        public bool Proyeccion { get { return proyeccion; } set { proyeccion = value; } }

        private string aul;
        public string Aul { get { return aul; } set { aul = value; } }



        /* public Aula(int i, int cap, bool con, bool proy)
         {
             this.id = i;
             this.capacidad = cap;
             this.conexionARed = con;
             this.proyeccion = proy;
         }*/


        public override string ToString()
        {
            return "ID: " + this.id + "\n" +
                    "Capacidad: " + this.capacidad + "\n" +
                    "Conexion a red: " + this.conexionARed + "\n" +
                    "Proyector: " + this.proyeccion + "\n" +
                    "Aula: " + this.aul;

        }

    }
}
