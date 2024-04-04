using System.ComponentModel.DataAnnotations;

public class RegisterModel
{
    [Key]
    public int UserID { get; set; }

    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$",
       ErrorMessage = "Password must be Minimum eight characters, at least one letter, one number and one special character.")]
    [Display(Name = "Password")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Confirm Password is required")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }
}
