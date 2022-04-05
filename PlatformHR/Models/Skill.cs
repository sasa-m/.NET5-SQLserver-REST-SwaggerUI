using System.Collections.Generic;

namespace PlatformHR.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Navigations Properties
        public List<CandidateSkill> CandidateSkills { get; set; }
    }
}
