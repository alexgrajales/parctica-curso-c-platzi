using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Modelo
{
    struct Curso
    {
        const string NOMB_CURSO = "No Asignado";
        public string NombreCurso { get; set; }
        public short max_capacidad;
        public Curso(short max_cap)
        {
            max_capacidad = max_cap;
            NombreCurso   = NOMB_CURSO;
        }
    }
}
