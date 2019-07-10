using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Asignaturas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Asign { get; set; }


        private List<String> _correlativas {get; set;}
        public List<string> correlativas { get{ return _correlativas;} set {_correlativas=value;}}


          [Required]
         public string StringsAsString
         {
            get { return String.Join(",", _correlativas); }
            set { _correlativas = value.Split(',').ToList(); }
         }



        public List<Alumno> inscriptos = new List<Alumno>();


        /*  public Asignaturas(string asig, List<string> correlatives)
          {
              this.Asign = asig;
              this.correlativas = correlatives;


          public Asignaturas()
          {

          } } */

    }
}
