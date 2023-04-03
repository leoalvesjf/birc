using BIRC.Models.Configuration;
using BIRC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BIRC.Models
{
    public class Contexto : DbContext
    {  
        public DbSet<SpareParts> SpareParts { get; set; }        
        public DbSet<SpareChemical> SpareChemical { get; set; }
        public DbSet<SpareRepairer> SpareRepairer { get; set; }
        public DbSet<SpareOffice> SpareOffice { get; set; }
        public DbSet<LogUpdate> LogUpdate { get; set; }
        public DbSet <VwLogUpdate> VwLogUpdate { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }//classe teste



        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
            modelBuilder.ApplyConfiguration(new SparePartsConfiguration());            
            modelBuilder.ApplyConfiguration(new SpareChemicalConfiguration());
            modelBuilder.ApplyConfiguration(new SpareRepairerConfiguration());
            modelBuilder.ApplyConfiguration(new SpareOfficeConfiguration());
            modelBuilder.ApplyConfiguration(new LogUpdateConfiguration());
            modelBuilder.ApplyConfiguration(new VwLogUpdateConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());

        }

        //public DbSet<BIRC.Models.Repositories.BaseModel> BaseModel { get; set; }

       

    }
}
