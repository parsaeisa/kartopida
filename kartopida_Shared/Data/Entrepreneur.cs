using System.Collections.Generic ;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Entrepreneur : Person
{       
    [Key]
    public int EntrepreneurID {get; set;}
    public Entrepreneur(){}
    public Entrepreneur( string firstname ,string lastname
    ,string username ,string password, string email
    , string phonenumber , string Description )
        :base(firstname , lastname
            ,username,password , email , phonenumber , Description )
    {}        

    public Entrepreneur(int id , string firstname ,string lastname
    ,string username ,string password, string email
    , string phonenumber , string Description
    ,string fields )
        :base(firstname , lastname
            ,username,password , email , phonenumber , Description )
    {
        this.EntrepreneurID = id ;
        this.fields = fields ;
    }        

    

    public string fields {get ; set;}     
    [NotMapped]
    public ICollection<Startup> startups {get; set;}

    public string startupsNames {get; set;}
}