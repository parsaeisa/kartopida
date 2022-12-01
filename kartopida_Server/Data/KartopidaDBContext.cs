using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class kartopidaDBContext : IdentityDbContext
{
    public kartopidaDBContext(DbContextOptions options) : base(options)
    {
    }    

    public DbSet<Clerk> clerks { get; set; }
    public DbSet<Entrepreneur> entrepreneurs { get; set; }
    public DbSet<Startup> startups { get; set; }
    public DbSet<Agahi> announcements {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {                        
        modelBuilder.Entity<Entrepreneur>().ToTable("Entrepreneurs");
        modelBuilder.Entity<Entrepreneur>().HasData(
            new Entrepreneur (1 , "علی" , "اسفندیاری" ,"ali_esfandiari" , "Password1!", "a_esf@yahoo.com" , "234235" , "توضیح3" , "مهندسی" )
        );

        modelBuilder.Entity<Startup>().ToTable("Startups");        
        modelBuilder.Entity<Startup>().HasData(
            new Startup(1 , "کافه بازار" , "AndroidApp" , "تهران" , "تهران" , 8,12 , "در حال استخدام"        
                , "cafeBazaar" , "تهران ، ونک" ,  1) 
        );
        modelBuilder.Entity<Clerk>().ToTable("Clerks");    
        modelBuilder.Entity<Clerk>().HasData(
            new Clerk(4 , "پارسا" , "عیس زاده" , "برنامه نویسی اندروید" 
                , "bachelor" ,"parsa_eisa" , "Password1!","Android" , "p_eissazadeh@comp.iust.ac.ir" , "09305709847" , "he's awesome") ,
            new Clerk( 2 , "امیرعلی" , "پاکدامن دنیوی " , "برنامه نویسی full-stack" 
                , "bachelor" ,"amirali_p" , "Password1!","full-stack developer" , "p_donyavi@comp.iust.ac.ir" , "34823094" , "He's awesome too")
        );    
        modelBuilder.Entity<Agahi>().ToTable("Announcements");        

        base.OnModelCreating(modelBuilder);
    }
}