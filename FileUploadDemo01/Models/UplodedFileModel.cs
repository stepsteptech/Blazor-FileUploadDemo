namespace FileUploadDemo01.Models
{
    public class UplodedFileModel
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
        public string FileUrl { get; set; }

    }
}
