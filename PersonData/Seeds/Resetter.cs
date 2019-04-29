using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonData
{
    public static class Resetter
    {
        public static void ResetData(SearchContext context)
        {
            context.Database.EnsureDeleted();
        }
    }
}
