namespace BulkyWebRazor_Temp.Models;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }
    
    [MaxLength(30)]
    [Required] [DisplayName("Category Name")] public string Name { get; set; }

    [DisplayName("Display Order")]
    [Range(1, 100)]
    public int DisplayOrder { get; set; }
}