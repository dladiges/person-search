using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonData;

namespace PersonService.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly PersonData.SearchContext context;

        public DataController(SearchContext context)
        {
            this.context = context;
        }

        // POST api/data/seed
        [HttpPost]
        public IActionResult Seed()
        {
            try
            {
                Seeder.SeedData(context);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        // Post api/data/reset
        [HttpPost]
        public IActionResult Reset()
        {
            try
            {
                Resetter.ResetData(context);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}