using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Make_your_own_api.DAL;
using Make_your_own_api.Models;

namespace Make_your_own_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarWars : ControllerBase
    {
        private readonly StarWarsDBContext _context;
        private readonly StarWarsAPIClient _starWarsAPIClient;

        public StarWars(StarWarsDBContext context, StarWarsAPIClient starWarsAPIClient)
        {
            _context = context;
            _starWarsAPIClient = starWarsAPIClient;
        }

        // GET: api/StarWars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StarWarsFanDAL>>> GetFans()
        {
            return await _context.Fans.ToListAsync();
        }

        // GET: api/StarWars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StarWarsFanPersonApiModel>> GetStarWarsFanDAL(string id)
        {

            var starWarsCharacter = await _starWarsAPIClient.GetSinglePerson(id);
            var starWarsFanDAL = await _context.Fans.FirstOrDefaultAsync(fan => fan.StarWarsCharacterId == id);


            if (starWarsFanDAL == null || starWarsCharacter == null)
            {
                return NotFound();
            }

            var response = new StarWarsFanPersonApiModel();

            response.IsAFan = starWarsFanDAL.IsAFan;
            response.PeronalNotes = starWarsFanDAL.PeronalNotes;

            response.Name = starWarsCharacter.name;
            response.Height = starWarsCharacter.height;
            response.HomeWorld = starWarsCharacter.homeworld;
            response.Mass = starWarsCharacter.mass;
            response.HairColor = starWarsCharacter.hair_color;
            response.Gender = starWarsCharacter.gender;

            return Ok(response);
        }



        // PUT: api/StarWars/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStarWarsFanDAL(string id, StarWarsFanDAL starWarsFanDAL)
        {
            if (id != starWarsFanDAL.Id)
            {
                return BadRequest();
            }

            _context.Entry(starWarsFanDAL).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StarWarsFanDALExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StarWars
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StarWarsFanDAL>> PostStarWarsFanDAL(StarWarsFanDAL starWarsFanDAL)
        {
            _context.Fans.Add(starWarsFanDAL);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StarWarsFanDALExists(starWarsFanDAL.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStarWarsFanDAL", new { id = starWarsFanDAL.Id }, starWarsFanDAL);
        }

        // DELETE: api/StarWars/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StarWarsFanDAL>> DeleteStarWarsFanDAL(string id)
        {
            var starWarsFanDAL = await _context.Fans.FindAsync(id);
            if (starWarsFanDAL == null)
            {
                return NotFound();
            }

            _context.Fans.Remove(starWarsFanDAL);
            await _context.SaveChangesAsync();

            return starWarsFanDAL;
        }

        private bool StarWarsFanDALExists(string id)
        {
            return _context.Fans.Any(e => e.Id == id);
        }
    }
}
