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
    public class QuejasController : ControllerBase
    {

        private readonly APIAppDbContext _dbContext;
        public QuejasController()
        {
            _dbContext = new APIAppDbContext();
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Queja> Get()
        {
            return _dbContext.Quejas.ToList();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public Queja Get(int id)
        {
            Queja u = _dbContext.Quejas.Find(id); //obtener queja por ID
            return u;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post(Queja queja)
        {
            _dbContext.Quejas.Add(queja);
            _dbContext.SaveChanges();
        }

        //// PUT api/<UsuarioController>/5
        [HttpPut]
        public void Put([FromBody] Queja model)
        {
            var att = _dbContext.Quejas.Attach(model);
            att.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _dbContext.SaveChanges();
        }

        //// DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Queja q = _dbContext.Quejas.Find(id);
            _dbContext.Quejas.Remove(q);
            _dbContext.SaveChanges();
        }
    }
}