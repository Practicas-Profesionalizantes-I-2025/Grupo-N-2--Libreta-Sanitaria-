using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Modelos
{
    public class Vacuna
    {
        public string Nombre { get; set; }
        public int Dosis { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        // Relaciones
        public int ConsultaId { get; set; }
        public Consulta Consulta { get; set; }
    }
}
