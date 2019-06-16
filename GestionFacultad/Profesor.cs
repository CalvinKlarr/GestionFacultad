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

        private List<string> materias;
        [Key]
        private int dni_ID;

        public Profesor(string name, string lname, int doc, int phone, string direcc, List<string> materias)
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni_ID = doc;
            this.tel = phone;
            this.direc = direcc;
            this.materias = materias = new List<string>();

        }
    }
}
