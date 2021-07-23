using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dtos
{
    public class BlogCategoryDto
    {
        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public string BlogHead { get; set; }
        public string CategoryName { get; set; }
    }
}
