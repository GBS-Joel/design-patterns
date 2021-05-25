namespace ZbW.DesignPatterns.Mediator
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Points { get; set; }

        public override string ToString() => $"Name: {Name}, Lastname: {LastName}";
    }
}
