using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    class Profesor: Usuario
    {
        [Key]
        public int id;
        public int Id { get { return id; } set { id = value; } }

        private List<string> materias;
       
        

        public Profesor(string name, string lname, int doc, int phone, string direcc, List<string> materias)
        {
            this.nombre = name;
            this.apellido = lname;
            this.id = doc;
            this.tel = phone;
            this.direc = direcc;
            this.materias = materias = new List<string>();

        }
    }
}
