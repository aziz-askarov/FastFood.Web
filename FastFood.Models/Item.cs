using System.ComponentModel.DataAnnotations;

namespace FastFood.Models;
public class Item
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public double Price { get; set; }

    public int Categoryid { get; set; }
    public Category Category { get; set; }
    public int SubCategoryid { get; set; }
    public Category SubCategory { get; set; }

}
