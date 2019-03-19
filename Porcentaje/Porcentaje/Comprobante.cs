using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   namespace Comprobante
{
    
        public class Comprobante
        {
            public string TipoDeComprobante { get; set; }
            public String DatosClientes { get; set; }
            public DateTime FechaDePago { get; set; }
            public DateTime FechaEm { get; set; }
            public DateTime FechaVen { get; set; }
            public string Detalle { get; set; }
            public decimal Importe { get; set; }
        }

    }


