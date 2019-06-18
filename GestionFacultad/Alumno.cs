using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Alumno: Usuario
    {

        private int id;
        public List<string> aprobadas = new List<string>();
        public int Id { get { return id; } set { id = value; } }

        public Alumno(string name, string lname, int doc, int phone, string direcc, int id)
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;
            this.id = id;

        }
    }
}
