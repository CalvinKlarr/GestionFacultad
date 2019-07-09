﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class Curso
    {
        public int id { get; set; }

        public Asignaturas[] asignaturas;
        public List<Alumno> alumnos = new List<Alumno>();

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
    }
}
