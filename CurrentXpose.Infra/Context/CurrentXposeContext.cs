using CurrentXpose.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CurrentXpose.Infra.Context
{
    public partial class CurrentXposeContext : DbContext
    {
        public virtual DbSet<Condominio> Condominio { get; set; }
        public virtual DbSet<Leitura> Leitura { get; set; }
        public virtual DbSet<Morador> Morador { get; set; }
        public virtual DbSet<Predio> Predio { get; set; }
        public virtual DbSet<Residencia> Residencia { get; set; }
        public virtual DbSet<Sindico> Sindico { get; set; }

        public CurrentXposeContext()
        {
        }

        public CurrentXposeContext(DbContextOptions<CurrentXposeContext> options) : base(options)
        {
        }

    }
}
