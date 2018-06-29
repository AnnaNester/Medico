using Model;
using System.Data.Entity;

namespace Controller.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("srtConn")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Medico> Medicos { get; set; }
    }
}
