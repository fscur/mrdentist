namespace MrDentist.Models
{
    public class Address
    {
        public int Id { get; private set; }
        public string Description { get; set; }

        public Address(int id)
        {
            Id = id;
        }
    }
}