using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Profesor: Usuario
    {

        public List<string> materias;
        
        private int dni_ID;
        [Key]
        public int Dni_ID { get { return dni_ID; } set { dni_ID = value; } }
        public Profesor()
        {

        }

        public Profesor(string name, string lname, int doc, int phone, string direcc, List<string> materias)
        {
            this.nombre = name;
            this.apellido = lname;
            this.Dni = doc;
            this.tel = phone;
            this.direc = direcc;
            this.materias = materias = new List<string>();

        }
    }
}
