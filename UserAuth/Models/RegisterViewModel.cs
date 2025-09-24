using System.ComponentModel.DataAnnotations;
public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public required string ConfirmPassword { get; set; }
}

// By default, passwords must have:
// At least 6 characters
// At least one non-alphanumeric character (e.g., !, @, #, $)
// At least one digit (0-9)
// At least one uppercase letter (A-Z)
// Test: Password!123