using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Modelo
{
    public abstract class  Persona : IEnteInstituto
    {

        public static int Contador { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto { get { return string.Format("{0} {1}", Nombre, Apellido); } }
        public virtual string NombreCompleto2
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }

        string IEnteInstituto.CogigoInterno
        {
            get;
            set;
        }

        public Persona()
        {
            Contador++;
        }

        public abstract string ConstruirResumen();

        string IEnteInstituto.ConstruirLLaveSecreta(string nombreEnte)
        {
            var rnd = new Random();
            return rnd.Next(1, 9998945).ToString();
        }
    }
}
