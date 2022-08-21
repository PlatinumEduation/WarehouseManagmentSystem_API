using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystem_API.infrastructure.Entities
{
    /// <summary>
    ///  Bridge Table >> between the Customers and the products 
    /// </summary>
    public class OrdersEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Order_Number { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Shipping Date: ")]
        public DateTime Order_shiping_Date { get; set; }
        public Address Address { get; set; }

        public Decimal Order_Subtotal { get; set; }

        // Navs
        public int Customers_Id { get; set; }
        public int Products_Id { get; set; }

        //Lazy loading >> not loading all the data 
        [ForeignKey("Customers_Id")]
        public virtual CustomerEntity? CustomersEntity { get; set; }
        [ForeignKey("Products_Id")]
        public virtual ProductsEntity? ProductsEntity { get; set; }

        //Nav props
        public List<OrderItems> OrderItems { get; set; }



    }
}
