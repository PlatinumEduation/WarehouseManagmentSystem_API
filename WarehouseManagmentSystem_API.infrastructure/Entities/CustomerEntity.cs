using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystem_API.infrastructure.Entities
{
    public class CustomerEntity:Person
    {

        [MaxLength(15)]
        public string? Contact_Name { get; set; }

        [MaxLength(20,ErrorMessage ="Business Name should be 20 characters long")]
        [Key]
        public string? Business_Name { get; set; }
        //Navs pros
        public virtual List<OrdersEntity> OrdersEntities { get; set; }


    }
}
