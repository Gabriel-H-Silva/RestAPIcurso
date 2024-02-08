using Microsoft.AspNetCore.Mvc;
using RestAPIcurso.Model;
using RestAPIcurso.Services;

namespace RestAPIcurso.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonServices _personServices;
        public PersonController(ILogger<PersonController> logger, IPersonServices personServices)
        {
            _logger = logger;
            _personServices = personServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personServices.FindById(id);

            if (person == null) return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personServices.Create(person));
        }


        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null) return BadRequest();

            return Ok(_personServices.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personServices.Delete(id);

            return NoContent();
        }
    }
}