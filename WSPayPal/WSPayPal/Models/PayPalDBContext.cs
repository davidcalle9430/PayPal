namespace WSPayPal.Models
{
    using System.Data.Entity;

    public class PayPalDBContext : DbContext
    {
        
        public PayPalDBContext() : base("name=PayPalDBContext")
        {
            Database.SetInitializer<PayPalDBContext>(
               new DropCreateDatabaseIfModelChanges<PayPalDBContext>()
           );
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public double Saldo { get; set; }

    }
}