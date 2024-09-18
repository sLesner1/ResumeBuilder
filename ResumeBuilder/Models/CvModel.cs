﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ResumeBuilder.Models
{
    public class CvModel
    {
        //public IFormFile Photo { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<ProfessionalExperience> ProfessionalExperience { get; set; } = new List<ProfessionalExperience>();
        public List<Education> Education { get; set; } = new List<Education>();
        public string Languages { get; set; }
        public string Training { get; set; }
        public string Profile { get; set; }
        public string Development { get; set; }
        public string Other { get; set; }
        public string Interests { get; set; }
        public string Links { get; set; }
        public string Consent { get; set; }
    }
}