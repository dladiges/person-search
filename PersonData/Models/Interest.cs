namespace PersonData
{
    public class Interest
    {
        public long InterestId { get; set; }
        public long PersonId { get; set; }
        public string Name { get; set; }

        public virtual Person Person { get; set; }
    }
}
