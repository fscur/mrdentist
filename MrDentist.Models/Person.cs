using System.Collections.Generic;

namespace MrDentist.Models
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<string> Phones { get; set; }
        public User User { get; set; }

        public Person(int id)
        {
            Id = id;
        }
    }
}
