namespace BMS.Data.Entities;

public class Table
{
    public int Id { get; set; }
    public int BranchId { get; set; }
    public Branch? Branch { get; set; }
    public string? Name { get; set; }
    public string? Model { get; set; }
    public string? Description { get; set; }
    public string? Color { get; set; }
    public ICollection<PriceList>? PriceLists { get; set; }
}