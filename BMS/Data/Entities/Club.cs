using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entities;

public class Club
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Introduction { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageSaveFileName { get; set; }
    public string? LogoUrl { get; set; }
    public string? LogoSaveFileName { get; set; }
    public int BranchNumber { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateCreated { get; set; }
    public ICollection<Branch>? Branches { get; set; }
}