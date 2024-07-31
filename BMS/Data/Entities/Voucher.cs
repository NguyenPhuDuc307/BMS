namespace BMS.Data.Entities;

public class Voucher
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public Event? Event { get; set; }
    public ICollection<VoucherDetail>? VoucherDetails { get; set; }
}