using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CashVan.API.Core
{
    public static class CoreFunction
    {
        public static string UploadedFile(IFormFile formFile, IWebHostEnvironment webHostEnvironment)
        {
            string uniqueFileName = null;

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath + "/images");
                uniqueFileName = Guid.NewGuid().ToString() + "." + formFile.ContentType.Replace("image/", string.Empty);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
