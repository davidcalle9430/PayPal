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
        string NombreUsuario;
        string Contrasenia;
        double Valor;


        [DataMember]
        public string NombreUsuario
        {
            get { return NombreUsuario; }
            set { NombreUsuario = value; }
        }

        [DataMember]
        public string Contrasenia
        {
            get { return Contrasenia; }
            set { Contrasenia = value; }
        }

        [DataMember]
        public double Contrasenia
        {
            get { return Valor; }
            set { Contrasenia = value; }
        }

    }
}
