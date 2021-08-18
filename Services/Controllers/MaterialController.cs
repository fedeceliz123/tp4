using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Negocio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        // GET: api/<MaterialController>
        [HttpGet("ConsultarSQL")]
        public ActionResult Consultar()
        {
            
            var consulta = new NegocioMatrial();
            var lista = consulta.Lista();
            try
            {
            return Ok(lista);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<MaterialController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MaterialController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MaterialController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MaterialController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
