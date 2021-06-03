using apiVacantes.Context;
using apiVacantes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiVacantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        readonly AppDBContext context;

        public CategoriaController(AppDBContext context)
        {
            this.context = context;
        }

        // GET: api/<CategoriaController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Categoria.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}", Name = "GetCategoria")]
        public ActionResult Get(int id)
        {
            try
            {
                var categoria = context.Categoria.FirstOrDefault(x => x.IdCategoria == id);
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public ActionResult Post([FromBody] Categoria categoria)
        {
            try
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
                return CreatedAtRoute("GetCategoria", new { id = categoria.IdCategoria }, categoria);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Categoria categoria)
        {
            try
            {
                if (categoria.IdCategoria == id)
                {
                    context.Entry(categoria).State = EntityState.Modified;
                    context.SaveChanges();
                    return NoContent();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var categoria = context.Categoria.FirstOrDefault(x => x.IdCategoria == id);
                if (categoria != null)
                {
                    context.Categoria.Remove(categoria);
                    context.SaveChanges();
                    return NoContent();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
