using FileUploadDemo01.Models;

namespace FileUploadDemo01.Services
{
    public interface IUploadFileService
    {
        Task AddNewFileAsync(UplodedFileModel model);
        //Lets get data to fill in table
        Task<List<UplodedFileModel>> GetAllFilesAsync();

    }
}
