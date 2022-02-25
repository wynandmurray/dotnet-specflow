namespace specflow_demo.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }

        public Person(int personId, string? firstName, string? lastName, string? emailAddress)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }
    }
}
