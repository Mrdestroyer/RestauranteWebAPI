using Microsoft.AspNetCore.Mvc;
using System;
using RestauranteWebAPI.Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestauranteWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private APIAppDbContext _context;
        public ProductosController()
        {
            _context = new APIAppDbContext();
        }
        // GET: api/<ProductosController>
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _context.Pedidos.ToList();
        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pedido ped = _context.Pedidos.Find(id);
            if(ped != null)
            {
                return Ok(ped);
            }
            return NotFound();
        }

        // POST api/<ProductosController>
        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return Ok(pedido);
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Pedido model)
        {
            var att = _context.Pedidos.Attach(model);
            att.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Pedido p = _context.Pedidos.Find(id);
            _context.Pedidos.Remove(p);
            _context.SaveChanges();
        }
    }
}
