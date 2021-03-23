using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbioFoodsApp.Models
{
    public class Transaction
    {

        public string TransactionId { get; set; }
        public string Total { get; set; }
        public string TransDate { get; set; }
        public BindingList<FoodItem> ItemsToSave { get; set; }
    }
}
