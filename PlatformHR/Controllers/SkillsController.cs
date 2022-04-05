using Microsoft.AspNetCore.Mvc;
using PlatformHR.ModelsView;
using PlatformHR.Repositories;

namespace PlatformHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private SkillsRepository _skillsRepository;

        public SkillsController(SkillsRepository skillsRepository)
        {
            _skillsRepository = skillsRepository;
        }

        [HttpPost("add-skill")]
        public IActionResult AddSkill([FromBody] SkillMV skill)
        {
            _skillsRepository.AddSkill(skill);
            return Ok();
        }

        [HttpGet("get-skill-with-candidates-by-id/{id}")]
        public IActionResult GetSkillWithCandidates(int id)
        {
            var response = _skillsRepository.GetSkillWithCandidates(id);
            return Ok(response);
        }
    }
}
