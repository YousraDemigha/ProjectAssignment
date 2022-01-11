using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeOrder.Database.Entities;
using MakeOrder.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MakeOrder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakeOrderController : ControllerBase
    {
        DatabaseContext db;
        public MakeOrderController()
        {
            db = new DatabaseContext();
        }


        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return db.Orders.ToList();
        }

        // GET api/<MakeOredrController>/5
        [HttpGet("{id}", Name = "Get")]
        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        // POST api/<MakeOrderController>
        [HttpPost]
        public IActionResult Post([FromBody] Order model)
        {
            try
            {
                db.Orders.Add(model);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT api/<MakeOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MakeOrderController>/5
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