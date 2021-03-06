using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dtos
{
    public class BlogLabelDto
    {
      
        public int BlogId { get; set; }
        public int LabelId { get; set; }
        public string BlogHead { get; set; }
        public string LabelName { get; set; }
        public string BlogBody { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImagePath { get; set; }
        public string ReadTime { get; set; }
    }
}
