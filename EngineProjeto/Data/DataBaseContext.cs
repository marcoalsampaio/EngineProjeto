
using EngineProjeto.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EngineProjeto.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public  DbSet<Pages> Pages { get; set; }
        public DbSet<InputType> InputType { get; set; }

        public DbSet<Teste> Teste { get; set; }
    }
}
