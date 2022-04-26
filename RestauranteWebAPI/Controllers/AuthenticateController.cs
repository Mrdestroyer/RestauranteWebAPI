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
    public class AuthenticateController : ControllerBase
    {


        private APIAppDbContext _dbContext;
        public AuthenticateController()
        {
            _dbContext = new APIAppDbContext();
        }
        // POST api/<AuthenticateController>
        [HttpPost]
        public IActionResult Post(Usuario user)
        {
            Usuario f = _dbContext.Usuarios.Where(x => x.NombreUsuario == user.NombreUsuario
            && x.Contrasena == user.Contrasena).FirstOrDefault();

            if(f == null)
            {
                return Unauthorized();
            }

            return Ok(f);
        }

    }
}
