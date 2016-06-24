using institucion.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.DataAcces
{
    public class IntitucionBD : DbContext
    {
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno>   Alumnos{ get; set; }
    }
}
