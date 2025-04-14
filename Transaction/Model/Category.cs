using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace AppTransaction.Model;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(10)]
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}
