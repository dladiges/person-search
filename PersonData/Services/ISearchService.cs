using System.Collections.Generic;

namespace PersonData
{
    public interface ISearchService
    {
        List<Person> SearchPeople(string searchText, int maxResultCount);
    }
}