using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.Identity;
using BMS.Data.Entities.System;
using BMS.Data.Entities;

namespace BMS.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<User>
{
    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<User>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
        builder.Entity<Permission>()
                .HasKey(c => new { c.RoleId, c.FunctionId, c.CommandId });
        builder.Entity<CommandInFunction>()
                .HasKey(c => new { c.CommandId, c.FunctionId });
        builder.Entity<OrderDetail>()
                .HasKey(c => new { c.OrderId, c.ProductId });
        builder.Entity<VoucherDetail>()
                .HasKey(c => new { c.VoucherId, c.PriceListId });

        builder.HasSequence("vnLab_Seq");
    }

    public DbSet<Command> Commands { set; get; } = default!;
    public DbSet<CommandInFunction> CommandInFunctions { set; get; } = default!;
    public DbSet<ActivityLog> ActivityLogs { set; get; } = default!;
    public DbSet<Function> Functions { set; get; } = default!;
    public DbSet<Permission> Permissions { set; get; } = default!;

    public DbSet<Club> Clubs { set; get; } = default!;
    public DbSet<Branch> Branches { set; get; } = default!;
    public DbSet<Shift> Shifts { set; get; } = default!;
    public DbSet<Salary> Salaries { set; get; } = default!;
    public DbSet<SalaryDetail> SalaryDetails { set; get; } = default!;
    public DbSet<Table> Tables { set; get; } = default!;
    public DbSet<PriceList> PriceLists { set; get; } = default!;
    public DbSet<Category> Categories { set; get; } = default!;
    public DbSet<Product> Products { set; get; } = default!;
    public DbSet<Member> Members { set; get; } = default!;
    public DbSet<MemberDetail> MemberDetails { set; get; } = default!;
    public DbSet<Order> Orders { set; get; } = default!;
    public DbSet<OrderDetail> OrderDetails { set; get; } = default!;
    public DbSet<Event> Events { set; get; } = default!;
    public DbSet<Voucher> Vouchers { set; get; } = default!;
    public DbSet<VoucherDetail> VoucherDetails { set; get; } = default!;
}

