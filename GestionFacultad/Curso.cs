using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    class Curso
    {
        public int id { get; set; }

        private Asignaturas[] asignaturas;
        private List<Alumno> alumnos;
        private Aula aula;
        private string cur;
        public string Cur { get { return cur; } set { cur = value; } }
        private string division;
        public string Division { get { return division; } set { division = value; } }


    }
}
