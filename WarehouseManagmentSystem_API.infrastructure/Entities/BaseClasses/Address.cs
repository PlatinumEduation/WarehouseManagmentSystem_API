using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagmentSystem_API.infrastructure.Entities.BaseClasses
{
    public class Address
    {
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Address_1 { get; set; }
        public string? Address_2 { get; set; }
    }
}
