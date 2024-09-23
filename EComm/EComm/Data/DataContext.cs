using EComm.Models;
using Microsoft.EntityFrameworkCore;

namespace EComm.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}