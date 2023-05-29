using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApiExample.Modelo
{
    public class PuntosPremios
    {
        public int PremiosId { get; set; }

        public string Descripcion { get; set; }

        public int Existencias { get; set; }

        public DateTime FechaAlta { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Puntos { get; set; }

        public byte[] Imagen { get; set; }
    }
}
