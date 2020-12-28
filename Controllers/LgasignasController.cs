using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIs.Models;

namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LgasignasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LgasignasController(AppDbContext contexto)
        {
            _context = contexto;
        }

        //ver completo listado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lgasigna>>> VerLgasigna()
        {
            return await _context.Lgasigna.ToListAsync();
        }

        //listar paametrizado
        [HttpGet("{Documento}")]
        public async Task<ActionResult<Lgasigna>> Listarasignacion(string Documento)
        {
            var lgasigna = await _context.Lgasigna.FindAsync(Documento);
            try
            {
                if (lgasigna == null)
                {
                    return NotFound();
                }

                return lgasigna;
            }
            catch (Exception ex)
            {
                throw;
            }
           
        }
    }
}
