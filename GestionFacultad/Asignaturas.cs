using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Asignaturas
    {
        [Key]
        public string Asign { get; set; }
        public List<string> correlativas = new List<string>();
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
