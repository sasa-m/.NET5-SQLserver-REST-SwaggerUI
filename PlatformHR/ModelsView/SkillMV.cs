using System.Collections.Generic;

namespace PlatformHR.ModelsView
{
    public class SkillMV
    {
        public string Name { get; set; }
    }

    public class SkillWithCandidatesMV
    {
        public string Name { get; set; }

        public List<string> CandidateNames { get; set; }
    }
}
