using _1.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerID { get; set; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public DateTime DateCreated { set; get; }
        public string linkImage { set; get; }
        public string Note { set; get; }

        public Status Status { set; get; }
        public Producer Producer { set; get; }
        //public List<ProductInProducer> ProductInProducers { get; set; }
        //public List<ProductInEmployee> ProductInEmployees { get; set; }
        public List<OrderDetail> OderDetails { get; set; }
        public List<ImportHistory> ImportHistories { get; set; }


    }
}
