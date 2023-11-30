using FlagsApi.Models;
using Microsoft.EntityFrameworkCore;

public class FlagsDBContext : DbContext
{
    public FlagsDBContext(DbContextOptions<FlagsDBContext> options)
        : base(options)
    {
        
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Language> Languages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define relationships
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.HasMany(e => e.Currencies).WithMany(e => e.Countries);
            entity.HasMany(e => e.Languages).WithMany(e => e.Countries);
            entity.HasOne(e => e.Flag).WithOne(e => e.Country).HasForeignKey<Flag>(e => e.CountryId);
            entity.HasMany(e => e.RegionalBlocs).WithOne(e => e.Country);
            entity.HasOne(e => e.Translations).WithOne(e => e.Country).HasForeignKey<Translations>(e => e.CountryId);
            entity.HasOne(e => e.Latlng).WithOne(e => e.Country).HasForeignKey<Latlng>(e => e.CountryId);
            entity.HasMany(e => e.AltSpellings).WithOne(e => e.Country);
            entity.HasMany(e => e.Borders).WithOne(e => e.Country).HasForeignKey(e => e.CountryId);
            entity.HasMany(e => e.CallingCodes).WithOne(e => e.Country);
            entity.HasMany(e => e.Timezones).WithOne(e => e.Country);
            entity.HasMany(e => e.TopLevelDomain).WithOne(e => e.Country);


        });
        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

           
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

           
        });

        modelBuilder.Entity<Flag>(entity =>
        {
            entity.HasKey(e => e.Id); // Assuming Id is the primary key for Country
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
          
           
        });

        modelBuilder.Entity<RegionalBloc>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

 
        });

        modelBuilder.Entity<Translations>(entity =>
        {
            entity.HasKey(e => e.Id); // Assuming Id is the primary key for Country
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        modelBuilder.Entity<Latlng>(entity =>
        {
            entity.HasKey(entity => entity.Id);
            entity.Property(entity => entity.Id).ValueGeneratedOnAdd();


        });
        modelBuilder.Entity<Border>(entity =>
        {
            entity.HasKey(entity => entity.Id);
            entity.Property(entity => entity.Id).ValueGeneratedOnAdd();
            
        });
        modelBuilder.Entity<AltSpellings>(entity =>
        {
            entity.HasKey(entity => entity.Id);
            entity.Property(entity => entity.Id).ValueGeneratedOnAdd();

        });
        modelBuilder.Entity<CallingCodes>(entity =>
        {
            entity.HasKey(entity => entity.Id);
            entity.Property(entity => entity.Id).ValueGeneratedOnAdd();

            

        });
        modelBuilder.Entity<Timezones>(entity =>
        {
            entity.HasKey(entity => entity.Id);
            entity.Property(entity => entity.Id).ValueGeneratedOnAdd();


        });
        modelBuilder.Entity<TopLevelDomain>(entity =>
        {
            entity.HasKey(entity => entity.Id);
            entity.Property(entity => entity.Id).ValueGeneratedOnAdd();


        });


        // If you want to specify any additional configurations or keys:
        // modelBuilder.Entity<Country>().HasKey(c => c.Id);
        // modelBuilder.Entity<Currency>().HasKey(currency => currency.Id);
        // modelBuilder.Entity<Language>().HasKey(language => language.Id);
    }
}
