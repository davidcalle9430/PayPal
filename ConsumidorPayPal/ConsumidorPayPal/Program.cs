using ConsumidorPayPal.PayPalReference;

namespace ConsumidorPayPal
{
    class Program
    {
        static void Main(string[] args)
        {
            PayPalClient client = new PayPalClient();
            var result = client.pagar(new Transaccion()
            {
                NombreUsuario = "David",
                Contrasenia = "swDavid",
                Valor = 30.0
            });

            System.Console.WriteLine( result );
            System.Console.ReadLine();

 
        }
    }
}
