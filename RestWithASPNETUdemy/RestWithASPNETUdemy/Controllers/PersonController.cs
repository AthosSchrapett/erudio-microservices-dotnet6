using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Models;
using RestWithASPNETUdemy.Services.Implementations;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _persorService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _persorService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_persorService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _persorService.FindById(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_persorService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_persorService.Update(person));
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _persorService.Delete(id);
            return NoContent();
        }

    }
}