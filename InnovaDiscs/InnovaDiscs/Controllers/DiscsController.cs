using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InnovaDiscs.Context;
using InnovaDiscs.Models;
using InnovaDiscs.Repositories.Interfaces;

namespace InnovaDiscs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscsController : ControllerBase
    {
        private readonly IDiscRepository _DiscRepository;

        public DiscsController(IDiscRepository DiscRepository)
        {
            _DiscRepository = DiscRepository;
        }

        // GET: api/Discs
        [HttpGet]
        public ActionResult<IEnumerable<Disc>> GetDiscs()
        {
            return _DiscRepository.GetAll();
        }

        // GET: api/Discs/5
        [HttpGet("{Id}")]
        public ActionResult<Disc>? GetDisc(int Id)
        {
            var disc = _DiscRepository.GetById(Id);

            if (disc == null)
            {
                return NotFound();
            }

            return Ok(disc);
        }

        // PUT: api/Discs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public ActionResult<Disc> PutDisc(int id, Disc disc)
        {
            if (id != disc.Id)
            {
                return BadRequest();
            }

            disc = _DiscRepository.Update(disc);

            return Ok(disc);
        }

        // POST: api/Discs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Disc> PostDisc(Disc disc)
        {
            disc = _DiscRepository.Add(disc);
            return Ok(disc);
            
        }

        // DELETE: api/Discs/5
        [HttpDelete("{id}")]
        public ActionResult DeleteDisc(int id)
        {
            _DiscRepository.Delete(id);
           
            return NoContent();
        }
    }
}
