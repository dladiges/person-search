using System.Collections.Generic;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using PersonData;

namespace PersonService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        // POST api/search/
        [HttpPost]
        public ActionResult<IList<Person>> Search([FromForm]string searchText, [FromForm] int maxResultCount=10, [FromForm] int searchDelaySeconds = 0)
        {
            DelayResponse(searchDelaySeconds);

            var matchedPeople = searchService.SearchPeople(searchText, maxResultCount);

            return matchedPeople;
        }

        private void DelayResponse(int seconds)
        {
            if (seconds > 0)
                Thread.Sleep(seconds * 1000);
        }
    }
}