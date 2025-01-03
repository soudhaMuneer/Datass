using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;

namespace HireMeNow_BlazorApp.Helpers
{
   
    public class FileUploadHelper
    {
        IWebHostEnvironment webHostEnvironment;
        public FileUploadHelper(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment=_webHostEnvironment;
        }
        public async Task<string> UploadFile(IBrowserFile file)
        {
            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");

            if (!Directory.Exists(uploadsFolder))
            {
                // Create the "Uploads" folder if it doesn't exist
                Directory.CreateDirectory(uploadsFolder);
            }

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.Name);
            string filePath = Path.Combine(uploadsFolder, fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.OpenReadStream().CopyToAsync(fileStream);
            }
            return fileName;
        }

        private async Task<byte[]> ConvertImageToByteArray(IBrowserFile file)
        {
            using var stream = file.OpenReadStream();
            using var memoryStream = new MemoryStream();
            await stream.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
