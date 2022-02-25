using specflow_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace specflow_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecflowController : ControllerBase
    {
        /// <summary>
        /// Gets random people data.
        /// </summary>
        /// <returns>People data.</returns>
        [HttpGet("specflow/getpeople")]
        public IActionResult GetPeople()
        {
            var people = PopulatePeople();

            return Ok(people);
        }

        /// <summary>
        /// Gets some people records.
        /// </summary>
        /// <returns>A list of <see cref="Person"/> objects.</returns>
        private List<Person> PopulatePeople()
        {
            var people = new List<Person>()
            {
                new Person(1, "Danny", "Stephens", "danny@company.org"),
                new Person(2, "Emily", "Stone", "emily@company.org"),
                new Person(3, "Joe", "Fredericks", "joe@company.org"),
                new Person(4, "Alice", "Cross", "alice@company.org"),
                new Person(5, "Michael", "Black", "michael@company.org")
            };

            return people;
        }
    }
}