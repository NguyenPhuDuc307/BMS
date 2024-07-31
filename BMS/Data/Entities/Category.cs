namespace BMS.Data.Entities;

public class Category
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? LogoUrl { get; set; }
    public string? LogoSaveFileName { get; set; }
    public int ParentId { get; set; }
    public ICollection<Product>? Products { get; set; }
}