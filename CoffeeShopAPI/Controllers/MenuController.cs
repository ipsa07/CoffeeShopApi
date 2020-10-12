using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopAPI.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private CoffeeshopDBContext _context;
        public MenuController(CoffeeshopDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetMenu")]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client)]
        public IActionResult GetMenu()
        {
            var menu = _context.Menu.Include("SubMenus");
            return Ok(menu);
        }

        [HttpGet("{id}")]
        [Route("Get/{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _context.Menu.Include("SubMenus").FirstOrDefault(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }
        [HttpGet("[action]")]
        public IActionResult PagingMenu(int? pageNumber, int? pageSize)
        {
            var menu = _context.Menu;
            var currentPageNumber = pageNumber ?? 1;
            var currentPageSize = pageSize ?? 5;
            return Ok(menu.Skip((currentPageNumber - 1) * currentPageSize).Take(currentPageSize));
        }

    }
}
