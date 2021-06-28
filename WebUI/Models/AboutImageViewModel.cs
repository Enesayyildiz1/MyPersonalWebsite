using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AboutImageViewModel
    {
        public About Abouts { get; set; }
        public IEnumerable<AboutImage> AboutImages { get; set; }
    }
}
