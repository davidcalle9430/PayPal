using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paypal.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public double Saldo { get; set; }
    }
}