using FileUploadDemo01.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadDemo01.dbcontext
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=DataBase\FileUploadDemo1.db");
        public DbSet<UplodedFileModel> uplodedFileModels { get; set; }

    }
}
