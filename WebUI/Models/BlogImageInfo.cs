using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class BlogImageInfo
    {
        public int Id { get; set; }
        public string BlogBody { get; set; }
        public string BlogHead { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
        public string ReadTime { get; set; }
    }
}
