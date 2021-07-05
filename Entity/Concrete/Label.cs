using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Label:IEntity
    {
        public int Id { get; set; }
        public string LabelName { get; set; }
    }
}
