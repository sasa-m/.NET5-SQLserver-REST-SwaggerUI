using PlatformHR.Models;
using PlatformHR.ModelsView;
using System.Collections.Generic;
using System.Linq;

namespace PlatformHR.Repositories
{
    public class CandidatesRepository
    {
        private readonly AppDbContext _context;

        public CandidatesRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddCandidateWithSkills(CandidateMV candidate)
        {
            var _candidate = new Candidate()
            {
                FullName = candidate.FullName,
                DateOfBirth = candidate.DateOfBirth,
                ContactNumber = candidate.ContactNumber,
                Email = candidate.Email
            };
            _context.Candidates.Add(_candidate);
            _context.SaveChanges();

            foreach (var id in candidate.SkillIds)
            {
                var _candidate_skill = new CandidateSkill()
                {
                    CandidateId = _candidate.Id,
                    SkillId = id
                };
                _context.CandidatesSkills.Add(_candidate_skill);
                _context.SaveChanges();
            }

        }

        public List<Candidate> GetAllCandidates()
        {
            var allCandidates = _context.Candidates.ToList();
            return allCandidates;
        }

        public CandidateWithSkillsMV GetCandidateById(int candidateId)
        {
            var _candidateWithSkills = _context.Candidates.Where(n => n.Id == candidateId).Select(candidate => new CandidateWithSkillsMV()
            {
                FullName = candidate.FullName,
                DateOfBirth = candidate.DateOfBirth,
                ContactNumber = candidate.ContactNumber,
                Email = candidate.Email,
                SkillNames = candidate.CandidateSkills.Select(n => n.Skill.Name).ToList()
            }).FirstOrDefault();

            return _candidateWithSkills;
        }

        public Candidate UpdateCandidateById(int candidateId, CandidateMV candidate)
        {
            var _candidate = _context.Candidates.FirstOrDefault(m => m.Id == candidateId);
            if (_candidate != null)
            {
                _candidate.FullName = candidate.FullName;
                _candidate.DateOfBirth = candidate.DateOfBirth;
                _candidate.ContactNumber = candidate.ContactNumber;
                _candidate.Email = candidate.Email;

                _context.SaveChanges();
            }

            return _candidate;
        }

        public void DeleteCandidateById(int candidateId)
        {
            var _candidate = _context.Candidates.FirstOrDefault(m => m.Id == candidateId);

            if(_candidate != null)
            {
                _context.Candidates.Remove(_candidate);
                _context.SaveChanges();
            }
        }
    }
}
