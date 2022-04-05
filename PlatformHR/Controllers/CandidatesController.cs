using Microsoft.AspNetCore.Mvc;
using PlatformHR.ModelsView;
using PlatformHR.Repositories;

namespace PlatformHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        public CandidatesRepository _candidatesRepository;

        public CandidatesController(CandidatesRepository candidatesRepository)
        {
            _candidatesRepository = candidatesRepository;
        }

        
        [HttpGet("get-all-candidates")]
        public IActionResult GetAllCandidates()
        {
            var allCandidates = _candidatesRepository.GetAllCandidates();
            return Ok(allCandidates);
        }

        [HttpGet("get-candidate-by-id/{id}")]
        public IActionResult GetCandidateById(int id)
        {
            var candidate = _candidatesRepository.GetCandidateById(id);
            return Ok(candidate);
        }


        [HttpPost("add-candidate-with-skills")]
        public IActionResult AddCandidate([FromBody]CandidateMV candidate)
        {
            _candidatesRepository.AddCandidateWithSkills(candidate);
            return Ok();
        }

        [HttpPut("update-candidate-by-id/{id}")]
        public IActionResult UpdateCandidateById(int id, [FromBody]CandidateMV candidate)
        {
            var updateCandidate = _candidatesRepository.UpdateCandidateById(id, candidate);
            return Ok(updateCandidate);
        }

        [HttpDelete("delete-candidate-by-id/{id}")]
        public IActionResult DeleteCandidateById(int id)
        {
            _candidatesRepository.DeleteCandidateById(id);
            return Ok();
        }
    }
}
