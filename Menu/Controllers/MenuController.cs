using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Menu.Database.Entities;
using Menu.Database;
using Microsoft.Extensions.Logging;

namespace Menu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        DatabaseContext db;
        public MenuController()
        {
            db = new DatabaseContext();
        }


        [HttpGet]
        public IEnumerable<Food> Get()
        {
            return db.Foods.ToList();
        }

        // GET api/<MenuController>/5
        [HttpGet("{id}", Name = "Get")]
        public Food Get(int id)
        {
            return db.Foods.Find(id);
        }

        // POST api/<MenuController>
        [HttpPost]
        public IActionResult Post([FromBody] Food model)
        {
            try
            {
                db.Foods.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<MenuController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Hello, this is the index!");
            return View();
        }
    }
}
