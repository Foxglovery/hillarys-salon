using System.ComponentModel.DataAnnotations;

namespace HillarysSalon.Models;

public class Customer
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
}