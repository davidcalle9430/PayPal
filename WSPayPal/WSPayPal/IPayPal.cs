using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WSPayPal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPayPal" in both code and config file together.
    [ServiceContract]
    public interface IPayPal
    {
        [OperationContract]
        bool pagar(Transaccion transaccion);    
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
