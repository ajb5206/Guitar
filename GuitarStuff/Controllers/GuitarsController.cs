using System.Collections.Generic; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuitarStuff.Models;
using System.Linq;

namespace GuitarStuff.Controllers
{
	//[ApiVersion("1.0")]
	[Route("api/[controller]")]
	[ApiController]
	public class GuitarsController : ControllerBase
	{
		private readonly GuitarStuffContext _db;

		public GuitarsController(GuitarStuffContext db)
		{
			_db = db;
		}

		// GET api/guitars
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Guitar>>> Get(string guitarType, string guitarPlayersAssociated)
		{
			var query = _db.Guitars.AsQueryable();

			if (guitarType != null)
			{
				query = query.Where(e => e.GuitarType == guitarType);
			}

			if (guitarPlayersAssociated != null)
			{
				query = query.Where(e => e.GuitarPlayersAssociated == guitarPlayersAssociated);
			}
			return await query.ToListAsync();
		}

		// POST api/guitars
		[HttpPost]
		public async Task<ActionResult<Guitar>> Post(Guitar guitar)
		{
			_db.Guitars.Add(guitar);
			await _db.SaveChangesAsync();

			return CreatedAtAction(nameof(GetGuitar), new { id = guitar.GuitarId }, guitar);
		}

		// GET: api/Guitar/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Guitar>> GetGuitar(int id)
		{
			var guitar = await _db.Guitars.FindAsync(id);

			if(guitar == null)
			{
				return NotFound();
			}

			return guitar;
		}

		//PUT: api/Guitars/5
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, Guitar guitar)
		{
			if (id != guitar.GuitarId)
			{
				return BadRequest();
			}

			_db.Entry(guitar).State = EntityState.Modified;

			try
			{
				await _db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!GuitarExists(id))
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


		//DELETE: api/Guitars/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteGuitar(int id)
		{
			var guitar = await _db.Guitars.FindAsync(id);
			if (guitar == null)
			{
				return NotFound();
			}

			_db.Guitars.Remove(guitar);
			await _db.SaveChangesAsync();

			return NoContent();

		}
		private bool GuitarExists(int id)
		{
			return _db.Guitars.Any(e=> e.GuitarId == id);
		}
	}
}