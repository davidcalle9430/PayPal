using System;

namespace PayPal
{
    public class PayPal : IPayPal
    {

        public bool pagar(Transaccion transaccion)
        {
            var usuarioQuemado = new
            {
                NombreUsuario = "David",
                Contrasenia = "David",
                Saldo = 3000.0
            };
            if ( transaccion.Valor < usuarioQuemado.Saldo )
            {
                return true;
            }
            return false;
        }
    }
}
