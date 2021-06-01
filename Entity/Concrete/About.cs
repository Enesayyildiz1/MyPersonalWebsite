using Core.Entities;
using System;

namespace Entity.Concrete

{
    public class About :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Github { get; set; }
        public string StackOverFlow { get; set; }
        public string Mail { get; set; }
        public string AboutMe { get; set; }
        public string Youtube { get; set; }
        public string ShortAbout { get; set; }
        public string Instagram { get; set; }

    }
}
