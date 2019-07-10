using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Alumno: Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}


        private List<String> _aprobadas{get; set;}
        public List<string > aprobadas{get{return _aprobadas;} set{_aprobadas= value;} }

         [Required]
         public string StringsAsString
         {
            get { return String.Join(",", _aprobadas); }
            set { _aprobadas = value.Split(',').ToList(); }
         }
        

        public Alumno(string name, string lname, int doc, int phone, string direcc)
        {
            this.nombre = name;
            this.apellido = lname;
            this.dni = doc;
            this.tel = phone;
            this.direc = direcc;
            

        }

        public Alumno()
        {

        }
    }
}
