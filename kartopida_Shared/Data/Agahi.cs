using System.Collections.Generic;
using System.ComponentModel.DataAnnotations ;
using System.ComponentModel.DataAnnotations.Schema;

public class Agahi
{
    [Key]
    public int AnnouncementID {get; set;}
    public Agahi(){ 
        count = 0 ;         
        Origin = new Startup();
    }

    public Agahi(int id , string title , string Field , int re , int count , string req , int originid)
    {
        this.AnnouncementID = id ;
        this.title =title ;
        this.Field = Field ;
        this.RequiredEmployees =re ;
        this.count =count ;
        this.Requirments = req ;
        this.originID = originid ;
        Origin = new Startup();
    }
    public int originID {get; set;}
    public Startup Origin {get; set;}
    [Required]
    public string title {get; set;}    
    [Required]
    public string Field {get; set;}
    [Required] 
    public int RequiredEmployees {get; set;}
    [Required]    
    public string Requirments {get; set;}
        
    public int count {get; set;}
    [NotMapped]
    public bool isTaken {
        get{
            return (count > RequiredEmployees);
        }
    }
}