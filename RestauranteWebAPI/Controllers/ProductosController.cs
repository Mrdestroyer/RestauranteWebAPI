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
        public IEnumerable<Producto> Get()
        {
            return _context.Productos.ToList();
        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Producto ped = _context.Productos.Find(id);
            if(ped != null)
            {
                return Ok(ped);
            }
            return NotFound();
        }

        // POST api/<ProductosController>
        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();

            return Ok(producto);
        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Producto model)
        {
            var att = _context.Productos.Attach(model);
            att.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Producto p = _context.Productos.Find(id);
            _context.Productos.Remove(p);
            _context.SaveChanges();
        }
    }
}
