namespace PersonData
{
    public class PersonService : IPersonService
    {
        private readonly SearchContext context;

        public PersonService(SearchContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Persist a person entity to the database
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Person Create(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return person;
        }
    }
}
