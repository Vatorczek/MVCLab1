using System.ComponentModel.DataAnnotations;

namespace Portfelik.Models;

public class Expense
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Kategoria")]
    public string? Category { get; set; }

    [Required]
    [Range(0.01, 999999.99, ErrorMessage = "Kwota musi być większa niż 0")]
    [Display(Name = "Kwota (zł)")]
    public decimal Amount { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Data")]
    public DateTime Date { get; set; }
}