using System.ComponentModel.DataAnnotations;
using BMS.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BMS.Data.Entities.System;

public class User : IdentityUser, IDateTracking
{
    public User()
    {
    }

    public User(string id, string userName, string firstName, string lastName, string email, string phoneNumber, DateTime dob)
    {
        Id = id;
        UserName = userName;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Dob = dob;
    }

    [MaxLength(50)]
    [Required]
    public string? FirstName { get; set; }

    [MaxLength(50)]
    [Required]
    public string? LastName { get; set; }

    [Required]
    public DateTime Dob { get; set; }

    public string? Avatar { get; set; }
    public string? Description { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public ICollection<Shift>? Shifts { get; set; }
    public ICollection<Salary>? Salaries { get; set; }
}