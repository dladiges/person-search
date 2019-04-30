using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonService
{
    public class SearchParameters
    {
        public string SearchText { get; set; }
        public int MaxResultCount { get; set; }
        public int DelayInSeconds { get; set; }

    }
}
