using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCIntro.Models.ViewModels;

public class ArticleViewModel
{
    public List<Tutorial> tutorials { get; set; }
    
    public ArticleViewModel()
    {
        tutorials = new List<Tutorial>();
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter article title")]
    [Display(Name = "Please enter article title")]
    public string ArticleTitle { get; set; }

    [Required(ErrorMessage = "Please enter article content")]
    [Display(Name = "Write article")]
    public string ArticleContent { get; set; }

    public int TutorialId { get; set; }
}