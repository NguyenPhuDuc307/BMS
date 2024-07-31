using System.ComponentModel.DataAnnotations.Schema;

namespace BMS.Data.Entities;

public class Product
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public string? Name { get; set; }
    public string? Introduction { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageSaveFileName { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public double Price { get; set; }
    public bool Status { get; set; }
    public ICollection<OrderDetail>? OrderDetails { get; set; }
}