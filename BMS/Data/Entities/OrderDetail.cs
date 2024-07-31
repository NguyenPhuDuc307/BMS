using System.ComponentModel.DataAnnotations.Schema;

namespace BMS.Data.Entities;

public class OrderDetail
{
    public int OrderId { get; set; }
    public Order? Order { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int Number { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public double Price { get; set; }

    public string? Note { get; set; }
}