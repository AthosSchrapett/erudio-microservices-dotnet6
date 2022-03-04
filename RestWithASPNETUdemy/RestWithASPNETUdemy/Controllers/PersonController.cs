using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Models;
using RestWithASPNETUdemy.Services.Implementations;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersorService _persorService;

        public PersonController(ILogger<PersonController> logger, IPersorService personService)
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

        [HttpPost]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_persorService.Update(person));
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
                return decimalValue;
            return 0;
        }
    }
}