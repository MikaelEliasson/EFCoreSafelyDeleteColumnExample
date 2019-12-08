namespace EFCoreSafelyDeleteColumnExample
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        // PropToBeDeleted is being deleted. Currently it exists in DB but not in queries.
        //public string PropToBeDeleted { get; set; }
    }
}
