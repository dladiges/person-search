namespace PersonData
{
    public class PersonService : IPersonService
    {
        private readonly SearchContext context;

        public PersonService(SearchContext context)
        {
            this.context = context;
        }

        public Person Create(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();
            return person;
        }
    }
}
