using System.ComponentModel.DataAnnotations.Schema;
using BMS.Data.Enums;
using BMS.Data.Interfaces;

namespace BMS.Data.Entities;

public class Order : IDateTracking
{
    public int Id { get; set; }
    public int TableId { get; set; }
    public Table? Table { get; set; }
    public string? CustomerName { get; set; }
    public string? CustomerPhoneNumber { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public double TotalPrice { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public double DiscountPrice { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public double FinalPrice { get; set; }

    public PaymentMethod PaymentMethod { get; set; }
    public int? MemberId { get; set; }
    public Member? Member { get; set; }
    public string? Note { get; set; }
    public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? LastModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ICollection<OrderDetail>? OrderDetails { get; set; }
}