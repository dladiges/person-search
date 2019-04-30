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

        //[HttpOptions]
        //public void Options() { return Ok(); }

        // POST api/search/
        [HttpPost]
        public ActionResult<IList<Person>> Search(SearchParameters searchParameters)
        {
            DelayResponse(searchParameters.DelayInSeconds);

            var matchedPeople = searchService.SearchPeople(searchParameters.SearchText, searchParameters.MaxResultCount);

            return matchedPeople;
        }

        private void DelayResponse(int seconds)
        {
            if (seconds > 0)
                Thread.Sleep(seconds * 1000);
        }
    }
}