using Porcentaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeIntereses
{
    class EjercicioComprobante
    {
       

        static void Main(string[] args)
        {

            Comprobante.Comprobante comp1 = new Comprobante.Comprobante();
            
           
            
            comp1.FechaEm = new DateTime(2019, 2, 5);
            
            Console.WriteLine("INGRESE NOMBRE:");
            comp1.DatosClientes = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE LA FECHA DE PAGO (Ingresar dd mm aaaa) : ");
            comp1.FechaVen = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE LA FECHA DE VENCIMIENTO : ");
            comp1.FechaDePago = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE TIPO DE FACTURA (Ingresar A,B,C) : ");
            comp1.TipoDeComprobante = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("INGRESE DETALLE (Ingresar por ejemplo:Impuesto de electricidad):");
        
            comp1.Detalle = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("INGRESE EL IMPORTE DE LA FACTURA : ");
            comp1.Importe = Convert.ToDecimal(Console.ReadLine());
            
            


            var recargoService = new RegladeRecargoService();
            var recargoCobrar = recargoService.Recargo(comp1);

            
            

            Console.ReadKey();
        }

    }
}
