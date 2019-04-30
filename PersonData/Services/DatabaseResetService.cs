using System;
using System.Collections.Generic;
using System.Text;

namespace PersonData
{
    public class DatabaseResetService : IDatabaseResetService
    {
        private readonly SearchContext context;

        public DatabaseResetService(SearchContext context)
        {
            this.context = context;
        }

        public void Reset()
        {
            context.Database.EnsureDeleted();
        }
    }
}
