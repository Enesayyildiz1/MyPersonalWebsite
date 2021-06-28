using Core.Entities;
using System;

namespace Entity.Concrete

{
    public class About :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public string Mail { get; set; }
        public string AboutMe { get; set; }      
        public string ShortAbout { get; set; }
        public string AboutTheBlog { get; set; }
        public string MySkillsAndExperience { get; set; }
        public string SideTodos { get; set; }


    }
}
