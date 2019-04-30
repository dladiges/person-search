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

        public List<Person> SearchPeople(string searchText, int maxResultCount)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return new List<Person>();

            var matchedPeople = searchContext.People
                .Where(x => x.GivenName.Contains(searchText) || x.FamilyName.Contains(searchText))
                .OrderBy(x => x.GivenName).ThenBy(x => x.FamilyName)
                .Take(maxResultCount)
                .ToList();

            return matchedPeople;
        }
    }
}
