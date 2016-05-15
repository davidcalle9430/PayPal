using WSPayPal.Fachada;


namespace WSPayPal
{
    public class PayPal : IPayPal
    {
        private FachadaUsuarios fachada = new FachadaUsuarios();
        public bool pagar( Transaccion transaccion )
        {
            var usuario = fachada.darUsuario(transaccion.NombreUsuario, transaccion.Contrasenia);
            if ( usuario != null && transaccion.Valor < usuario.Saldo)
            {
                return fachada.restarSaldo( usuario , transaccion.Valor );
            }
            return false;
        }
    }
}
