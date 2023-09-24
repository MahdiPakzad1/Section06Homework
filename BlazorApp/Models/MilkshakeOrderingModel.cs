using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models;

public class MilkshakeOrderingModel
{
    [Required]
    [MinLength(1,ErrorMessage ="Select a milkshake type.")]
    public string TypleOfMilkshake { get; set; }

    [Required]
    [MinLength(1, ErrorMessage = "Select a milkshake size.")]
    public string SizeOfMilkshake { get; set; }

    [Required]
    [MinLength(2, ErrorMessage = "You need to give us a name for your order.")]
    public string OrderName { get; set; }

    [Range(minimum:1,maximum:10,ErrorMessage ="Insert a number between 1 to 10.")]
    public int Quantity { get; set; }

    public bool AddWhippedCream { get; set; }


}
