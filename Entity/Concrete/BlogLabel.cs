using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class BlogLabel:IEntity
    {
        public int BlogId { get; set; }
        public int LabelId { get; set; }
    }
}
