using System.ComponentModel.DataAnnotations ;
using System.ComponentModel.DataAnnotations.Schema;
// namespace kartopida_Shared
// {
public class Person
    {        
        public Person()
        {}   
        public Person(string firstname ,string lastname
        ,string username, string password
        ,string email
        , string phonenumber , string Description )
        {
            this.username = username ;
            this.firstname = firstname ;
            this.lastname = lastname ;
            this.email = email ;            
            this.phonenumber = phonenumber ;
            this.Description = Description ;
            this.password = password ;
        }

        public Person(string firstname ,string lastname
        ,string username ,string email
        , string phonenumber , string Description )
        {
            this.username = username ;
            this.firstname = firstname ;
            this.lastname = lastname ;
            this.email = email ;            
            this.phonenumber = phonenumber ;
            this.Description = Description ;            
        }

        [Required]
        public string firstname {get ; set;}
        [Required]
        public string lastname {get ; set;}

        public string name {
            get{
                return firstname + " " + lastname ;
            }
        }
        [Required]
        public string username {get ; set;}

        [Required]
        [EmailAddress(ErrorMessage="پست الکترونیکی اشتباه است ")]
        public string email {get ; set;}

        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, ErrorMessage = "تعداد ارقام شماره تلفن زیاد است .")]
        public string phonenumber {get; set;}        
        
        [Required]
        [DataType(DataType.Password )]
        public string password {get ; set;}

        [Required]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "رمز های عبور مطابقت ندارند ")]
        [NotMapped]
        public string ConfirmPassword {get; set;}

        [NotMapped]
        public bool IsAuthenticated {get; set;}

        public string Description {get; set;}

    }
// }