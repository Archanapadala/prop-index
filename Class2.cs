

namespace prop_index
{
    class Customer
    {
        //int id; string name;
        ////Fully Qualified Property
        //public int ID
        //{
        //    set { id = value; }
        //    get { return id; }
        //}

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

    }
    class Class2
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Enter Customer Details: ");
            customer.CustomerID = Convert.ToInt32(Console.ReadLine());
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("Customer ID is: " + customer.CustomerID);
            Console.WriteLine("Customer Name is: " + customer.CustomerName);
            Console.Read();
        }
    }

}
