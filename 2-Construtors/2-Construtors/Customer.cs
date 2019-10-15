using System.Collections.Generic;

namespace _2_Construtors
{
    public class Customer
    {
        public int id;
        public string name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int ID)
            : this()
        {
            this.id = ID;

        }
        public Customer(int ID, string Name)
            : this(ID)
        {
            this.id = ID;
            this.name = Name;
        }
        public void Promote()
        {

        }
    }
}
