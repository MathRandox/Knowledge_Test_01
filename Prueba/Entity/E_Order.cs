using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entity
{
    public class E_Order
    {
        private long Id_Order { get; set; }
        private long Id_Customer { get; set; }
        private DateTime Created_At_Order { get; set; }
        private decimal Total_Amount_Order { get; set; }
        private long Id_Payment_Type { get; set; }
        private long Id_Discount { get; set; }
        private long Id_Shipping_Method { get; set; }
        private long Id_Shipping_Address { get; set; }
    }
}
