using System.ComponentModel.DataAnnotations;

public class LoginDTO
{
    [Required]
    [EmailAddress]
    public string UserEmail { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string UserPassword { get; set; }
}
