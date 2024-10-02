
using System;

namespace Prueba.Entity
{
    public class E_Products
    {
        private long Id_Product {  get; set; }
        private string Name_Product { get; set; }
        private string Description_Product { get; set; }
        private decimal Price_Product { get; set; }
        private int StockQuantity { get; set; }
        private DateTime CreateAt { get; set; } = DateTime.UtcNow;
        private DateTime UpdateAt { get; set; } = DateTime.UtcNow;
        private long Id_Status { get; set; }
        private long Id_Supplier { get; set; }
        private long Id_Category { get; set; }

    }
}
