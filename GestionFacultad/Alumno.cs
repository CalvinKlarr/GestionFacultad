using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Alumno: Usuario
    {

        private int id;
        private List<string> _aprobadas = new List<string>();
        public List<string> aprobadas { get { return _aprobadas; } set { _aprobadas = value; } }
        
        public string aprobadasDB
        {
            get { return String.Join(",", _aprobadas); }
            set { _aprobadas = value.Split(',').ToList(); }
        }
        public int Id { get { return id; } set { id = value; } }

        public Alumno(string name, string lname, int doc, int phone, string direcc)
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;
            

        }
        public override string ToString()
        {
            return nombre +" "+ apellido;
        }
        public Alumno()
        {

        }
    }
}
