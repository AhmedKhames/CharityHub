using CharityHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CharityHub.Infrastructure;

public class CharityHubDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Owners { get; set; }
    public DbSet<UserSession> Accounts { get; set; }
}