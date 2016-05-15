using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WSPayPal.Models;

namespace WSPayPal.Fachada
{
    public class FachadaUsuarios
    {
        private PayPalDBContext db;

        public EntityState EntiryState { get; private set; }

        public FachadaUsuarios()
        {
            db = new PayPalDBContext();   
        }


        public bool restarSaldo(Usuario usuario, double resta)
        {

            if (resta > 0 && usuario.Saldo - resta >= 0)
            {
                usuario.Saldo = usuario.Saldo - resta;
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public Usuario darUsuario( string NombreUsuario , string Contrasenia)
        {
            try
            {
                var usuario = db.Usuarios.Where(u => u.NombreUsuario == NombreUsuario && u.Contrasenia == Contrasenia).First<Usuario>();
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool crearUsuario( Usuario usuario )
        {
            try
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return true;
            }
            catch( Exception)
            {
                return false;
            }
        }
    }
}