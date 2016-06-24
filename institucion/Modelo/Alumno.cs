using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Modelo
{
    public class Alumno : Persona
    {
        private string nickName { get; set; }

        public EstadosAlumno estado { get; set; }
        public string Email { get; set; }
        public Alumno()
        {
            nickName = "agv";
        }

        public override string ConstruirResumen()
        {
            return $"{NombreCompleto2},{nickName}, {Telefono}";
        }

        public override string NombreCompleto2
        {
            get
            {
                return base.NombreCompleto2.ToUpper();
            }
        }
    }
}
