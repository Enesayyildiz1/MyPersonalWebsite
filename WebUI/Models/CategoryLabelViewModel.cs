using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class CategoryLabelViewModel
    {
       public  List<Category> Categories { get; set; }
        public List<Label>Labels { get; set; }
        
    }
}
