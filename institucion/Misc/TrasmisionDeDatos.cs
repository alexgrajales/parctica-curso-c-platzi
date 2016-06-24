using institucion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion.Misc
{
    class TrasmisionDeDatos
    {
        public delegate string Formatter(string input);
        public void FormatearYEnviar(IEnteInstituto ente, Formatter localFormatter, string nombre)
        {
            var rawString = $"{ente.CogigoInterno}:{ente.ConstruirLLaveSecreta(nombre)}";
            rawString = localFormatter(rawString);
            Enviar(rawString);
        }

        private void Enviar(string rawString)
        {
            Console.WriteLine(rawString);

            if (InformacionEnviada != null)
                InformacionEnviada(this, new EventArgs());
        }

        public event EventHandler InformacionEnviada;
    }
}
