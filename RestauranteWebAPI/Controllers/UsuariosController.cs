using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestauranteWebAPI.Model.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestauranteWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly APIAppDbContext _dbContext;
        public UsuarioController()
        {
            _dbContext = new APIAppDbContext();
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _dbContext.Usuarios.ToList();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            Usuario u = _dbContext.Usuarios.Find(id); //obtener usuario por ID
            return u;
        }



        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] Usuario user)
        {
            _dbContext.Usuarios.Add(user);
            _dbContext.SaveChanges();
        }

        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}