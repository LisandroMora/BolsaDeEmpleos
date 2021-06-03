using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiVacantes.Context;
using apiVacantes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiVacantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacantesController : ControllerBase
    {
        readonly AppDBContext context;
        public VacantesController(AppDBContext context)
        {
            this.context = context;
        }
        // GET: api/<VacantesController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Trabajos.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<VacantesController>/5
        [HttpGet("{id}", Name = "GetTrabajo")]
        public ActionResult Get(int id)
        {
            try
            {
                var trabajo = context.Trabajos.FirstOrDefault(x => x.IdTrabajo == id);
                return Ok(trabajo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<VacantesController>
        [HttpPost]
        public ActionResult Post([FromBody] Trabajos trabajo)
        {
            try
            {
                context.Trabajos.Add(trabajo);
                context.SaveChanges();
                return CreatedAtRoute("GetTrabajo", new { id = trabajo.IdTrabajo }, trabajo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<VacantesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Trabajos trabajo)
        {
            try
            {
                if (trabajo.IdTrabajo == id)
                {
                    context.Entry(trabajo).State = EntityState.Modified;
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

        // DELETE api/<VacantesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var trabajo = context.Trabajos.FirstOrDefault(x => x.IdTrabajo == id);
                if (trabajo != null)
                {
                    context.Trabajos.Remove(trabajo);
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
