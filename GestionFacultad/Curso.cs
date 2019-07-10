using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Curso
    {
        public int id { get; set; }

        private List<string> _asignaturas = new List<string>();
        public List<string> asignaturas { get { return _asignaturas; } set { _asignaturas = value; } }
        public string asignaturasDB
        {
            get { return String.Join(",", _asignaturas); }
            set { _asignaturas = value.Split(',').ToList(); }
        }
        private List<string> _alumnoID = new List<string>();
        public List<string> alumnoID { get { return _alumnoID; } set { _alumnoID = value; } }
        public string alumnoIDDB
        {
            get { return String.Join(",", _alumnoID); }
            set { _alumnoID = value.Split(',').ToList(); }
        }

        public Aula aula { get; set; }



        private string cur;
        public string Cur { get { return cur; } set { cur = value; } }
        private string division;
        public string Division { get { return division; } set { division = value; } }
        private string curdivision;
        public string CurDivision { get { return curdivision; } set { curdivision = value; } }

        public Curso()
        {
            curdivision = cur + " - " + division;
        }

        public override string ToString()
        {
            return cur + " " + division;
        }
    }
}
