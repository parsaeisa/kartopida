
using System.Collections.Generic;
using System.Linq;

public  static class DBInitializer
{
    public static void Initialize(kartopidaDBContext context)
    {
        context.Database.EnsureCreated();

        // Look for any students.
        if (context.clerks.Any())
        {
            return;   // DB has been seeded
        }

        List<Agahi> Agahiha = new List<Agahi>{
            new Agahi(1 , "جاروکشی " , "نظافت" 
            ,5 , 2 , "1-غرنزنه 2- سخت کار کنه 3- خاطره تعریف نکنه" , 3)
        };
        foreach (var A in Agahiha)
        {
            context.announcements.Add(A);
        }
        context.SaveChanges();

        List<Clerk> clerks= new List<Clerk>{
                new Clerk(1 , "پارسا" , "عیس زاده" , "برنامه نویسی اندروید" 
                , "bachelor" ,"parsa_eisa" , "Password1!","Android" , "p_eissazadeh@comp.iust.ac.ir" , "09305709847" , "he's awesome") ,
                new Clerk( 2 , "امرعلی" , "پاکدامن" , "برنامه نویسی full-stack"
                , "bachelor" ,"amirali_p" , "Password1!","full-stack developer" , "p_donyavi@comp.iust.ac.ir" , "34823094" , "He's awesome too") ,
                new Clerk( 3 , "عرشیا" , "موسوی" , "مهندسی برق" 
                , "bachelor" ,"arshia_mu" , "Password1!", "electric cars" , "a_mousavi@elec.iust.ac.ir" , "2323535" , "he's not that awesome" )
            };

        foreach (var c in clerks)
        {
            context.clerks.Add(c);
        }
        context.SaveChanges();

        List<Entrepreneur> entrepreneurs = new List<Entrepreneur>{
            new Entrepreneur ("مجید" , "عیسی زاده " ,"mjd" , "Password1!" , "m@yahoo.com" , "345234" , "توضیح1") ,
            new Entrepreneur ("محمد" , "محمدی" ,"mhmmd" , "Password1!", "m@yahoo.com" , "34342423" , "توضیح2 ")  ,
            new Entrepreneur ("علی" , "اسفندیاری" ,"ali_esfandiari" , "Password1!", "a_esf@yahoo.com" , "234235" , "توضیح3" )
        };

        foreach (var e in entrepreneurs)
        {
            context.entrepreneurs.Add(e);
        }
        context.SaveChanges();

        Startup s = new Startup();
        s.name = "کارافزا" ;
        s.WorkingTitle = "لوله جات" ; 
        s.State = "تهران" ;
        s.City = "دماوند" ;
        s.Situation = "در حال استخدام" ;
        s.InternationalName = "karafza" ;
        s.StartWork = 9 ;
        s.EndWork = 18 ;
        s.Description = "اینجا خیلی حال میده" ;
        s.Address = "سردار جنگل" ;
        s.founder = new Entrepreneur("مارک" , "زاکربرگ" ,"mark_zuck","Password1!" , "sfsas@aefa.com"
        , "345554" , "مدیر عامل اسبق facebook");        

        List<Startup> startups = new List<Startup>{
            s ,
            new Startup("کافه بازار" , "AndroidApp" , "تهران" , "تهران" , 8,12 , "در حال استخدام"
            , "cafeBazaar" , "تهران ، ونک") ,
            new Startup("دیجیکالا" , "ُBuyingStuff" , "تهران" , "تهران" , 10 , 122 , "در حال استخدام"
            , "Digikala" , "تهران، ونک")
        };

        foreach (var startup in startups)
        {
            context.startups.Add(startup);
        }
        context.SaveChanges();

        
}
}