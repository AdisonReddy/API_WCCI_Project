using InnovaDiscs.Models;
using InnovaDiscs.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnovaDiscs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscGolfersController : ControllerBase
    {
        private readonly IDiscGolferRepository _DiscGolferRepository;

        public DiscGolfersController(IDiscGolferRepository DiscGolferRepository)
        {
            _DiscGolferRepository = DiscGolferRepository;
        }

        // GET: api/DiscGolfers
        [HttpGet]
        public ActionResult<IEnumerable<DiscGolfer>> GetDiscGolfer()
        {
            return _DiscGolferRepository.GetAll();
            
        }

        // GET: api/DiscGolfers/5
        [HttpGet("{id}")]
        public ActionResult<DiscGolfer>? GetDiscGolfer(int id)
        {
            var discGolfer = _DiscGolferRepository.GetById(id);

            if (discGolfer == null)
            {
                return NotFound();
            }

            return Ok(discGolfer);
        }

        // PUT: api/DiscGolfers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public ActionResult<DiscGolfer> PutDiscGolfer(int id, DiscGolfer discGolfer)
        {
            if (id != discGolfer.Id)
            {
                return BadRequest();
            }

            discGolfer = _DiscGolferRepository.Update(discGolfer);

            return Ok(discGolfer);
        }

        // POST: api/DiscGolfers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<DiscGolfer> PostDiscGolfer(DiscGolfer discGolfer)
        {
            discGolfer = _DiscGolferRepository.Add(discGolfer);
            return Ok(discGolfer);
        }

        // DELETE: api/DiscGolfers/5
        [HttpDelete("{id}")]
        public ActionResult DeleteDiscGolfer(int id)
        {
            _DiscGolferRepository.Delete(id);

            return NoContent();
        }
    }
}
