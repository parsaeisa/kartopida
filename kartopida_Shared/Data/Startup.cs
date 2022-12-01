using System.Collections.Generic ;
using System.ComponentModel.DataAnnotations ;
using System.ComponentModel.DataAnnotations.Schema;

public class Startup
{
    public Startup(string name , string workingTitle
    , string state , string city 
    ,int StartWork , int EndWork
    , string situation
    , string englishName , string Address)
    {
        this.name = name ;
        this.WorkingTitle = workingTitle ;
        this.State = state;
        this.City = city;        
        this.Situation = situation ;
        this.InternationalName = englishName ;
        this.Address = Address ;
    }

    public Startup(int id , string name , string workingTitle
    , string state , string city 
    ,int StartWork , int EndWork
    , string situation
    , string englishName , string Address , int founderID)
    {
        this.StartupID = id ;
        this.name = name ;
        this.WorkingTitle = workingTitle ;
        this.State = state;
        this.City = city;        
        this.Situation = situation ;
        this.InternationalName = englishName ;
        this.Address = Address ;
        this.founderID = founderID ;
    }
    public Startup()
    {
        StartWork = 8 ;
        EndWork = 16 ;
    }
    [Key]
    public int StartupID {get; set;}
    public int founderID {get; set;}
    public Entrepreneur founder {get; set;}    
    public IEnumerable<Entrepreneur> entrepreneurs {get; set;}    
    public IEnumerable<Clerk> clerks {get; set;}
    [Required]
    public string name {get; set;}
    [Required]
    public string WorkingTitle {get; set;}
    [Required]
    public string InternationalName {get; set;}    
    public int StartWork {get; set;}
    public int EndWork {get; set;}

    [Required]
    public string City {get; set;}
    [Required]
    public string State {get; set;}
    [Required]
    public string Situation {get; set;}
    [Required]
    public string Address {get; set;}
    public string Description {get; set;}
    public string Entres {get; set;}
    public string Clers {get; set;}
    
    public IEnumerable<Agahi> Agahiha {get; set;}
    public string Field {get; set;}
}   
