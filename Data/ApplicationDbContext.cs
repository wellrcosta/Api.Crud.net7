using Api.Crud.net7.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Crud.net7.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public required DbSet<Student> Students { get; set; }
}