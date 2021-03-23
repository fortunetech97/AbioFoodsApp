using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbioFoodsApp.Models
{
    public class FoodItem
    {
        public string Item_Name { get; set; }
        public int Quantity { get; set; }
        public int Size_in_Kg { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
    }
}
