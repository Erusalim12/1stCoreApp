using Microsoft.EntityFrameworkCore;
using WebUI.Models.Entity;

namespace WebUI.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<DateTimeEntity> DateTimeRecords { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}