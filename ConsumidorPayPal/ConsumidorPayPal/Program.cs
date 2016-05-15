using ConsumidorPayPal.PaypalWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumidorPayPal
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client cliente = new Service1Client();
            Console.WriteLine( cliente.GetData( 5 ) );
            Console.ReadLine();
        }
    }
}
