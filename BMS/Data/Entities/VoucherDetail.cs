namespace BMS.Data.Entities;

public class VoucherDetail
{
    public int VoucherId { get; set; }
    public Voucher? Voucher { get; set; }
    public int PriceListId { get; set; }
    public PriceList? PriceList { get; set; }
    public int PercentDiscount { get; set; }
}