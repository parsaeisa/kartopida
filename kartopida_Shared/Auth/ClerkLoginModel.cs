using System.ComponentModel.DataAnnotations ;
public class ClerkLoginModel
{
    [Required]
    [EmailAddress]
    public string email { get; set; }

    [Required]
    public string password { get; set; }

    // public bool RememberMe { get; set; }
}