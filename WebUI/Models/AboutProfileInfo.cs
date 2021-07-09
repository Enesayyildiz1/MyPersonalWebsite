using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AboutProfileInfo
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
        public string FirstImagePath { get; set; }
        public string SecondImagePath { get; set; }
        public IFormFile FirstImage { get; set; }
        public IFormFile SecondImage { get; set; }
    }
}
