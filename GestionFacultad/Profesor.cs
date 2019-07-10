using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Profesor: Usuario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int dni_ID { get; set; }
       // public int Dni_ID { get { return dni_ID; } set { dni_ID = value; } }

        private List<String> _materias{get; set;}
        public List<string> materias{ get { return _materias; } set { _materias = value; } }

        [Required]
        public string StringsAsString
        {
        get { return String.Join(",", _materias); }
        set { _materias = value.Split(',').ToList(); }
        }




    


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


