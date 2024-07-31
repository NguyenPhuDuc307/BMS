using System.ComponentModel.DataAnnotations.Schema;
using BMS.Data.Interfaces;

namespace BMS.Data.Entities;

public class PriceList : IDateTracking
{
    public int Id { get; set; }
    public int TableId { get; set; }
    public Table? Table { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    [Column(TypeName = "decimal(18,0)")]
    public double Price { get; set; }
    public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? LastModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ICollection<VoucherDetail>? VoucherDetails { get; set; }
}