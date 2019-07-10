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

        private List<string> _materias = new List<string>();
        public List<string> materias { get { return _materias; } set { _materias = value; } }
        public string materiasDB
        {
            get { return String.Join(",", _materias); }
            set { _materias = value.Split(',').ToList(); }
        }
        
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
            this._materias = materias = new List<string>();

        }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
