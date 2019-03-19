using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porcentaje
{
    public class RegladeRecargoService
    {



        public decimal Recargo(Comprobante.Comprobante comprobante)
        {
            decimal Recargo = 0;
            decimal iva = 0;

            double[,] P2 = new double[4, 2] { { 15, 0.005  }, { 30, 0.03 }, { 60, 0.04 }, { 99999, 0.05 } };
            var c = (comprobante.FechaVen - comprobante.FechaDePago).Days;
            int fila = c;
            int col = 0;
            double[,] numero;
            numero = new double[4, 2];
            for (fila = 0; fila < 4; fila++)
            {
                for (col = 0; col < 2; col++)
                {

                    numero[fila, col] = P2[fila, col];

                }
                Console.WriteLine();
            }

            if (c > 0 && c <= 15)
            {
                
                iva = (comprobante.Importe * Convert.ToDecimal(P2[0, 1]));
                Console.Write(  "tienes  de Pago ");
            }
            else if (c > 15 && c <= 30)
            {
               
                iva = ((comprobante.Importe) * Convert.ToDecimal(P2[1, 1]));
                Console.WriteLine( "tienes  de Pago");
            }
            else if (c > 30 && c <= 60)
            {
               
                iva = ((comprobante.Importe) * Convert.ToDecimal(P2[2, 1]));
                Console.WriteLine( "Tiene  de Pago");
            }
            else if (c >= 60)
            {
                
                iva = ((comprobante.Importe) * Convert.ToDecimal(P2[3, 1]));
                Console.WriteLine( "Tiene  de Pago");
            }
            //else 
            //    {
            //        iva = (comprobante.Da);
            //        Console.WriteLine("No hay Iva");
            //    }

        
            
            Console.Clear();
                Console.WriteLine("NOMBRE : " + (comprobante.DatosClientes));
                Console.WriteLine("FECHA DE PAGO:" + comprobante.FechaVen);
                Console.WriteLine("FECHA DE VENCIMIENTO:" + comprobante.FechaDePago);
                Console.WriteLine("TIPO DE FACTURA:" + comprobante.TipoDeComprobante);
                Console.WriteLine("DETALLE: " + comprobante.Detalle);
                Console.WriteLine("Valor de la Factura: " + comprobante.Importe);
                Console.WriteLine("Interes : " + iva);
                Console.WriteLine("Total: " + (comprobante.Importe + (iva)));
                Console.WriteLine();
                Console.ReadLine();
                return Recargo;
         }
                
       




            
                
     }

}

        
   

