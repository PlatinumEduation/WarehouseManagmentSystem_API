using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystem_API.infrastructure.Entities
{
    public class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Item_Id { get; set; }

        //Navs 
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public int Item_Quantity { get; set; }

        // Eager Loading >> coz i will need to show all the details of the product 
        public ProductsEntity? ProductsEntity { get; set; }
        public OrdersEntity? OrdersEntity { get; set; }

    }
}
