using System.Data.Entity;

namespace VyBillettBestilling.DAL
{
    public interface IVyDbContext
    {
        DbSet<VyDbContext.DbBillett> Billetter { get; set; }
        DbSet<VyDbContext.DbBillettKjop> Billettkjop { get; set; }
        DbSet<VyDbContext.DbHovedstrekning> Hovedstrekninger { get; set; }
        DbSet<VyDbContext.DbHovedstrekningStasjon> HovstrStasj { get; set; }
        DbSet<VyDbContext.DbKunde> Kunder { get; set; }
        DbSet<VyDbContext.DbNett> Nett { get; set; }
        DbSet<VyDbContext.DbPassasjertype> Passasjertyper { get; set; }
        DbSet<VyDbContext.DbPris> Pris { get; set; }
        DbSet<VyDbContext.DbStasjon> Stasjoner { get; set; }
    }
}