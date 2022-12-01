using System.ComponentModel.DataAnnotations ;
using System.ComponentModel.DataAnnotations.Schema;

public class Clerk : Person
{  
    [Key]    
    public int ClerkID {get; set;}

    public Clerk(){}
    public Clerk(int id , string firstname, string lastname , string Fieldtitle
    , string degree ,string username, string password , string field
    , string email 
    , string phonenumber , string Description)
        :base(firstname , lastname , username , email , password
        , phonenumber , Description)
    {            
        this.Field = field ;
        this.FieldTitle = Fieldtitle ;
        this.degree = degree ;  
        this.ClerkID = id ;
        this.officeID = 0 ;
    }

    public Clerk(string firstname, string lastname , string Fieldtitle
    , string degree ,string username
    , string email 
    , string phonenumber , string Description)
        :base(firstname , lastname , username , email
        , phonenumber , Description)
    {                    
        this.FieldTitle = Fieldtitle ;
        this.degree = degree ;          
        this.officeID = 0 ;
    }

    [Required]
    public string Field {get ; set;}
    [Required]
    public string FieldTitle {get ; set;}        
    [Required]
    public string degree {get; set;}                        
    public int officeID {get; set;}                         
    public Startup Startup {get; set;}
}