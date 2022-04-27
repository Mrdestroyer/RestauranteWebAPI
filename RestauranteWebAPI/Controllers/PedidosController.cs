using Microsoft.AspNetCore.Mvc;
using RestauranteWebAPI.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestauranteWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private APIAppDbContext _context;
        public PedidosController()
        {
            _context = new APIAppDbContext();
        }
        // GET: api/<PedidosController>
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _context.Pedidos.ToList();
        }

        // GET api/<PedidosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Pedidos.Find(id));
        }
        
        /**
         *  OBTENER UNA LISTA DE PEDIDOS REALIZADA POR USUARIO
         */
        [HttpGet("usuario/{idUusario}")]
        public IEnumerable<Pedido> pedidosPorUsuario(int idUusario)
        {
            List<Pedido> listaPedidos = _context.Pedidos.Where(x => x.IdUsuario == idUusario).ToList();

            return listaPedidos;
        }


        //// POST api/<PedidosController>
        [HttpPost]
        public void Post([FromBody] Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        //// PUT api/<PedidosController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Pedido model)
        {
            var att = _context.Pedidos.Attach(model);
            att.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        //// DELETE api/<PedidosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Pedido p = _context.Pedidos.Find(id);
            _context.Pedidos.Remove(p);
            _context.SaveChanges();
        }
    }
}
