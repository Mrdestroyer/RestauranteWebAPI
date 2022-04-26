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
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{

        //}

        //// PUT api/<PedidosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PedidosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
