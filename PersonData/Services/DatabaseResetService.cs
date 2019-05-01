namespace PersonData
{
    public class DatabaseResetService : IDatabaseResetService
    {
        private readonly SearchContext context;

        public DatabaseResetService(SearchContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Summarily clears the database.
        /// Does not recreate the database. 
        /// </summary>
        public void Reset()
        {
            context.Database.EnsureDeleted();
        }
    }
}
