using _1.DAL.Enums;

namespace _1.DAL.Entities
{
    public class Employee
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public Status Status { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public Roles Roles { get; set; }
        public List<Order> Oders { get; set; }
        //trong 1 employee có nhiều oder

        //public List<ProductInEmployee> ProductInEmployees { get; set; }
        public List<ImportHistory> ImportHistories { get; set; }

    }
}
