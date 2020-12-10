using Microsoft.AspNetCore.Http;


namespace AccessJob.Models.Home
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
