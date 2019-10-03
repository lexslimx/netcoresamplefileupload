using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadSample.Models
{
    public class FileDto
    {       
        public string FileName { get; set; }
        public IFormFile ProfilePic { get; set; }
    }
}
