using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFacultad
{
    public class ProgramControl: DbContext
    {

        public DbSet<Asignaturas> Asigns { get; set; }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Profesor> Profes { get; set; }

        public DbSet<Aula> Aulas { get; set; }

        public ProgramControl()
        {

        }

        


    }
}
