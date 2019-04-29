using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonData;

namespace SearchService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly SearchContext context;

        public SearchController(SearchContext context)
        {
            this.context = context;
        }

        // POST api/search/
        [HttpPost]
        public ActionResult<IList<Person>> Search([FromForm]string searchText,[FromForm] int maxResultCount=10)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return new List<Person>();

            var matchedPeople = context.People
                .Where(x => x.GivenName.Contains(searchText) || x.FamilyName.Contains(searchText))
                .OrderBy(x => x.GivenName).ThenBy(x => x.FamilyName)
                .Take(maxResultCount)
                .ToList();

            return matchedPeople;
        }
    }
}