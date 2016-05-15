using System;
using System.Runtime.Serialization;
using System.ServiceModel;



namespace PayPal
{
    [ServiceContract]
    public interface IPayPal
    {
        [OperationContract]
        bool pagar( Transaccion transaccion );
    }

    [DataContract]
    public class Transaccion
    {
        string nombreUsuario;
        string contrasenia;
        double valor;


        [DataMember]
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        [DataMember]
        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        [DataMember]
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
