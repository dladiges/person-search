using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PersonData
{
    public class SearchService : ISearchService
    {
        private readonly SearchContext searchContext;

        public SearchService(SearchContext context)
        {
            this.searchContext = context;
        }

        /// <summary>
        /// Search for a given text string in either given or family (first or last) names
        /// </summary>
        /// <param name="searchText">Text string to search for</param>
        /// <param name="maxResultCount">maximum of results to return</param>
        /// <returns>Return a collection of Person entities with a maximum count of maxResultCount</returns>
        public List<Person> SearchPeople(string searchText, int maxResultCount)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return new List<Person>();

            var matchedPeople = searchContext.People
                .Include(p => p.Interests)
                .Where(x => x.GivenName.Contains(searchText) || x.FamilyName.Contains(searchText))
                .OrderBy(x => x.GivenName).ThenBy(x => x.FamilyName)
                .Take(maxResultCount)
                .ToList();

            return matchedPeople;
        }
    }
}
