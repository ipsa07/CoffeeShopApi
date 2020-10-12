using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopAPI.Data;
using CoffeeShopAPI.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private CoffeeshopDBContext _context;
        public OrderController(CoffeeshopDBContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }


        [HttpPut]
        public IActionResult EditOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderToEdit = _context.Order.Find(id);
            if (orderToEdit == null)
            {
                return NotFound("No record found against this Id");
            }

            orderToEdit.Name = order.Name;
            orderToEdit.Phone = order.Phone;
            orderToEdit.Email = order.Email;
            orderToEdit.Date = order.Date;
            orderToEdit.Time = order.Time;
            _context.SaveChanges();
            return Ok("Order Updated Successfully");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var orderToDelete = _context.Order.Find(id);
            if (orderToDelete == null)
            {
                return NotFound("No record found against this Id");
            }
            _context.Order.Remove(orderToDelete);
            _context.SaveChanges();
            return Ok("Order Deleted");

        }
    }
}
