using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIs.Models;
using Microsoft.EntityFrameworkCore;


namespace WebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoAsignadoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PedidoAsignadoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<PedidoAsignadoController> muestra todos los pedidos asignados de TODOS los usuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PedidosAsignados>>> Get()
        {
            return await _context.PedidosAsignados.ToListAsync();
        }

      
        // GET api/<PedidoAsignadoController>/5 por CodPer
        [HttpGet("{CodPer}")]
        public async Task<ActionResult<PedidosAsignados>> Get(string CodPer)
        {
            var pedidos = await _context.PedidosAsignados.FindAsync(CodPer);

            if (pedidos == null)
            {
                return NotFound();
            }

            return pedidos;
        }

        // POST api/<PedidoAsignadoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<PedidoAsignadoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PedidoAsignadoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
