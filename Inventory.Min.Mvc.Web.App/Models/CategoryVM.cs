using System.ComponentModel.DataAnnotations;
using ModelHelper;

namespace Inventory.Min.Mvc.Web.App.Models;

public class CategoryVM
    : Model
{
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMax)]
    public string? Name { get; set; }

    [MaxLength(DescriptionMax)]
    public string? Description { get; set; }
}