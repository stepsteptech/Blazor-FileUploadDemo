using FileUploadDemo01.dbcontext;
using FileUploadDemo01.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadDemo01.Services
{
    public class UploadFileService : IUploadFileService
    {
        public async Task AddNewFileAsync(UplodedFileModel model)
        {
            using(var context=new ApplicationDbContext())
            {
                await context.uplodedFileModels.AddAsync(model);
                await context.SaveChangesAsync();
            }

        }

        public async Task<List<UplodedFileModel>> GetAllFilesAsync()
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.uplodedFileModels.ToListAsync();
            }

        }
    }
}
