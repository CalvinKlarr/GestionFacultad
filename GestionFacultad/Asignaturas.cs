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
        
        public string Asign { get; set; }
        private List<string> _correlativas = new List<string>();
        public List<string> correlativas { get { return _correlativas; } set { _correlativas = value; } }
        
        public string correlativasDB
        {
            get { return String.Join(",", _correlativas); }
            set { _correlativas = value.Split(',').ToList(); }
        }
        private List<string> _inscriptos = new List<string>();
        public List<string> inscriptos { get { return _inscriptos; } set { _inscriptos = value; } }
        public string inscriptosDB
        {
            get { return String.Join(",", _inscriptos); }
            set { _inscriptos = value.Split(',').ToList(); }
        }
        


        /*  public Asignaturas(string asig, List<string> correlatives)
          {
              this.Asign = asig;
              this.correlativas = correlatives;


          public Asignaturas()
          {

          } } */

        public override string ToString()
        {
            return Asign;
        }

    }
}
