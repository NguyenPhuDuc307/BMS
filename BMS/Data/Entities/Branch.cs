using System.ComponentModel.DataAnnotations;

namespace BMS.Data.Entities;

public class Branch
{
    public int Id { get; set; }
    public int ClubId { get; set; }
    public Club? Club { get; set; }
    public string? Name { get; set; }
    public string? Introduction { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? PhoneNumber { get; set; }
    public int TableNumber { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateCreated { get; set; }
    public ICollection<Table>? Tables { get; set; }
}