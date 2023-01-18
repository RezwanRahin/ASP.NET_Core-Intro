using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCIntro.Models;

public class Tutorial
{
    public int Id { get; set; }

    [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z_]*$", ErrorMessage = "Please enter text")]
    [Required]
    [Display(Name = "Tutorial Name")]   
    public string Name { get; set; }

    [Required]
    [Display(Name = "Tutorial Description")]
    public string Description { get; set; }
}
