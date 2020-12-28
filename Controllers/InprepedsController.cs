using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InprepedsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InprepedsController(AppDbContext contexto)
        {
            _context = contexto;
        }

        // GET: api/<InprepedsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inpreped>>> VerInpreped()
        {
            return await _context.Inpreped.ToListAsync();
        }

        // GET api/<InprepedsController>/5
        [HttpGet("{NumPed}")]
        public async Task<ActionResult<Inpreped>> ListarInpre(string NumPed)
        {
            var inpreped = await _context.Inpreped.FindAsync(NumPed);
            try
            {
                if (inpreped == null)
                {
                    return NotFound();
                }

                return inpreped;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        // POST api/<InprepedsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<InprepedsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InprepedsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
