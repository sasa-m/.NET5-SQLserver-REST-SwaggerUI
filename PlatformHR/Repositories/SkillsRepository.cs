using PlatformHR.Models;
using PlatformHR.ModelsView;
using System.Linq;

namespace PlatformHR.Repositories
{
    public class SkillsRepository
    {
        private readonly AppDbContext _context;

        public SkillsRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddSkill(SkillMV skill)
        {
            var _skill = new Skill()
            {
                Name = skill.Name,
            };
            _context.Skills.Add(_skill);
            _context.SaveChanges();
        }

        public SkillWithCandidatesMV GetSkillWithCandidates(int skillId)
        {
            var _skill = _context.Skills.Where(n => n.Id == skillId).Select(n => new SkillWithCandidatesMV()
            {
                Name = n.Name,
                CandidateNames = n.CandidateSkills.Select(n => n.Candidate.FullName).ToList()
            }).FirstOrDefault();

            return _skill;
        }
    }
}
