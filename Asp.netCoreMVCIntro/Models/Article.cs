using System.ComponentModel.DataAnnotations;

namespace Asp.netCoreMVCIntro.Models;

public class Article
{
    public int ArticleId { get; set; }

    [Required(ErrorMessage = "Please enter article title")]
    public string ArticleTitle { get; set; }

    public string ArticleContent { get; set; }
}