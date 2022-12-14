using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Inventory.Min.Data;
using ModelHelper;
using Redwerb.BizArk.Core.StringExt;

namespace Inventory.Min.Mvc.Web.App.Models;

public class ItemVM
    : Model
{
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMax)]
    public string? Name { get; set; }

    [MaxLength(DescriptionMax)]
    public string? Description { get; set; }

    public int? InitialCount { get; set; }

    public int? CurrentCount { get; set; }

    [ForeignKey(nameof(Category))]
	public int? CategoryId { get; set; }

	[Column(TypeName = Datetime2Name)]
	public DateTime? PurchaseDate { get; set; }

    [ForeignKey(nameof(Currency))]
	public int? CurrencyId { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? PurchasePrice { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? SellPrice { get; set; }

    [MaxLength(PathMax)]
	public string? ImagePath { get; set; }

    [MaxLength(PathMax)]
	public string? ImagePath17 => ImagePath?.Wrap(17);

    [ForeignKey(nameof(Unit))]
	public int? LengthUnitId { get; set; }

    public double? Length { get; set; }

	public double? Heigth { get; set; }

	public double? Depth { get; set; }

    public double?  Diameter { get; set; }

    [ForeignKey(nameof(Unit))]
	public int? VolumeUnitId { get; set; }

    public double? Volume { get; set; }

    public double? Mass { get; set; }

    [ForeignKey(nameof(Unit))]
	public int? MassUnitId { get; set; }

    [ForeignKey(nameof(Tag))]
	public int? TagId { get; set; }

    [ForeignKey(nameof(State))]
	public int? StateId { get; set; }

    [ForeignKey(nameof(Item))]
	public int? ParentId { get; set; }

	public string? ParentName { get; set; }
}