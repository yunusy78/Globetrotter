using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.API.DAL.Context;

namespace Web.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetList()
        {
            using var context = new Context();
            var list = context.Visitors.ToList();
            return Ok(list);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using var context = new Context();
            var visitor = context.Visitors.Find(id);
            if (visitor == null)
            {
                return NotFound();
            }
            return Ok(visitor);
        }
        
        [HttpPost]
        public IActionResult Create(Web.API.DAL.Entities.Visitor visitor)
        {
            using var context = new Context();
            context.Visitors.Add(visitor);
            context.SaveChanges();
            return Created("", visitor);
        }
        
        [HttpPut]
        public IActionResult Update(Web.API.DAL.Entities.Visitor visitor)
        {
            using var context = new Context();
            var updatedVisitor = context.Visitors.Find(visitor.Id);
            if (updatedVisitor == null)
            {
                return NotFound();
            }
            updatedVisitor.Name = visitor.Name;
            updatedVisitor.Company = visitor.Company;
            updatedVisitor.Email = visitor.Email;
            updatedVisitor.Phone = visitor.Phone;
            updatedVisitor.Host = visitor.Host;
            updatedVisitor.CheckIn = visitor.CheckIn;
            updatedVisitor.CheckOut = visitor.CheckOut;
            updatedVisitor.Notes = visitor.Notes;
            updatedVisitor.IsCheckedOut = visitor.IsCheckedOut;
            context.Visitors.Update(updatedVisitor);
            context.SaveChanges();
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using var context = new Context();
            var visitor = context.Visitors.Find(id);
            if (visitor == null)
            {
                return NotFound();
            }
            context.Visitors.Remove(visitor);
            context.SaveChanges();
            return Ok();
        }
        
        
        
        
    }
}
