using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderStatus.Database.Entities;
using OrderStatus.Database;
using Microsoft.Extensions.Logging;

namespace OrderStatus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        DatabaseContext db;
        public OrderStatusController()
        {
            db = new DatabaseContext();
        }


        [HttpGet]
        public IEnumerable<Statu> Get()
        {
            return db.Status.ToList();
        }

        // GET api/<OrderStatusController>/5
        [HttpGet("{id}", Name = "Get")]
        public Statu Get(int id)
        {
            return db.Status.Find(id);
        }

        // POST api/<ORderControlerController>
        [HttpPost]
        public IActionResult Post([FromBody] Statu model)
        {
            try
            {
                db.Status.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<OrderStatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderStatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
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
    
