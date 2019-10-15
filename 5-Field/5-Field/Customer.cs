using System.Collections.Generic;

namespace _5_Field
{
    public class Customer
    {
        public int Id;
        public string name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;

        }
        public Customer(int ID, string Name)
            : this(ID)
        {
            this.Id = ID;
            this.name = Name;
        }
        public void Promote()
        {

        }
    }
}
