using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string BlogBody { get; set; }
        public string BlogHead { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImagePath { get; set; }
        public string ReadTime { get; set; }
    }
}
