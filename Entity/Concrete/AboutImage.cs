using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class AboutImage:IEntity
    {
        public int Id { get; set; }
        public int AboutId { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateTime { get; set; }
    }
}
