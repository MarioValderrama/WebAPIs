using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Web.Http.Description;
using System.Xml.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LgpersonsController : ControllerBase
    {
        private readonly AppDbContext _context;
       // private readonly SignInManager<Lgperson> _signInManager; //*********************

        public LgpersonsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Lgpersons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lgperson>>> GetLgperson()
        {
            return await _context.Lgperson.ToListAsync();
        }

        // GET: api/Lgpersons/5
        [HttpGet("{CodPer}")]
        public async Task<ActionResult<Lgperson>> GetLgperson(string CodPer)
        {
            var lgperson = await _context.Lgperson.FindAsync(CodPer);

            if (lgperson == null)
            {
                return NotFound();
            }

            return lgperson;
        }

        // PUT: api/Lgpersons/5      
        [HttpPut("{CodPer}")]
        public async Task<IActionResult> PutLgperson(string CodPer, Lgperson lgperson)
        {
            if (CodPer != lgperson.CodPer)
            {
                return BadRequest();
            }

            _context.Entry(lgperson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LgpersonExists(CodPer))
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

        // POST: api/Lgpersons
       [HttpPost]
        public async Task<ActionResult<Lgperson>> PostLgperson( Lgperson lgperson)
        {
            _context.Lgperson.Add(lgperson);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LgpersonExists(lgperson.CodPer))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLgperson", new { CodPer = lgperson.CodPer }, lgperson);
        }


        // DELETE: api/Lgpersons/5
        [HttpDelete("{CodPer}")]
        public async Task<ActionResult<Lgperson>> DeleteLgperson(string CodPer)
        {
            var lgperson = await _context.Lgperson.FindAsync(CodPer);
            if (lgperson == null)
            {
                return NotFound();
            }

            _context.Lgperson.Remove(lgperson);
            await _context.SaveChangesAsync();

            return lgperson;
        }

        private bool LgpersonExists(string CodPer)
        {
            return _context.Lgperson.Any(e => e.CodPer == CodPer);
        }
       
        //public async Task<ActionResult<Lgperson>> Login (string CodPer)
        //{
        //    try
        //    {
        //        var Result = from Lgperson in 
        //                     where CodPer = " "
        //                     select CodPer.ToList();
        //    }
        //    catch (DbUpdateException)
        //    {

        //    }
        //}

    }
}
