using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonData;

namespace PersonService.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDatabaseResetService resetService;
        private readonly IDatabaseSeedService seedService;

        public DataController(IDatabaseResetService resetService, IDatabaseSeedService seedService)
        {
            this.resetService = resetService;
            this.seedService = seedService;
        }

        // POST api/data/seed
        [HttpPost]
        public IActionResult Seed()
        {
            try
            {
                seedService.Seed();
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
                resetService.Reset();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}