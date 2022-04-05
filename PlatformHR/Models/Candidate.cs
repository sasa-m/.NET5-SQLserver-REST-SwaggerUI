using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlatformHR.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public int ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }

        //Navigations Properties
        public List<CandidateSkill> CandidateSkills { get; set; }
    }
}
