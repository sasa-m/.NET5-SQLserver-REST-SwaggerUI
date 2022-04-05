using System;
using System.Collections.Generic;

namespace PlatformHR.ModelsView
{
    public class CandidateMV
    {

        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int ContactNumber { get; set; }

        public string Email { get; set; }

        public List<int> SkillIds { get; set; }
    }


    public class CandidateWithSkillsMV
    {

        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int ContactNumber { get; set; }

        public string Email { get; set; }

        public List<string> SkillNames { get; set; }
    }
}
