using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteApi.Models;

namespace TesteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}", Name = "ObterCliente")]
        public ActionResult<Cliente> Get(int id)
        {
            var cliente = _context.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }
            return cliente;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {           
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterCliente", new { id = cliente.Id }, cliente);
        }
    }
}
