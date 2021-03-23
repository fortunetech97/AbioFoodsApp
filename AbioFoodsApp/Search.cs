using AbioFoodsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbioFoodsApp
{
    public partial class Search : Form
    {
        string TransactionFileData = Path.Combine(Environment.CurrentDirectory, "TrasactionFileData.txt");
      //  private BindingList<Transaction> transactions = new BindingList<Transaction>();
        public Search()
        {
            InitializeComponent();
        }
        public class TransactionCount {
            public string transactionId { get; set; }
            public int Items { get; set; }
            public string Amount { get; set; }
            
        }
        private void SecondSearchButton_Click(object sender, EventArgs e)
        {
            string transId = TransactionIDTextBox.Text;
            string searchDate = DateTextBox.Text;
            if (!string.IsNullOrWhiteSpace(transId)){
               
                var tran = LoadAllTransactionByID(transId);
                if (tran == null) 
                {
                    MessageBox.Show("No transaction with this transactionID");
                    return;
                }
                ItemsGrid.DataSource = tran.ItemsToSave;
               
            }
               
            if(!string.IsNullOrWhiteSpace(searchDate)){

              var trans=  LoadAllTransactionByDate(searchDate);
                var transCounts = new List<TransactionCount>();
                foreach (var item in trans)
                {
                    var tranCount = new TransactionCount { transactionId = item.TransactionId, Items = item.ItemsToSave.Count, Amount = item.Total };
                    transCounts.Add(tranCount);
                }
                ItemsGrid.DataSource = transCounts;
            }
        }

        private BindingList<Transaction> LoadAllTransactions()
        {
            BindingList<Transaction> transactions = new BindingList<Transaction>();
            foreach (var line in File.ReadLines(TransactionFileData))
            {
                var transaction = new Transaction();
                var items = new BindingList<FoodItem>();
                var transProps = line.Split('#')[0].Split(';');
                transaction.TransactionId = transProps[0];
                transaction.TransDate = transProps[1];
                transaction.Total = transProps[2];
                var allItems = line.Split('#')[1];

                if (allItems.Contains("$"))
                {

                    var eachItem = allItems.Split('$');
                    foreach (var item in eachItem)
                    {
                        var eachItemProp = item.Split(';');
                        FoodItem foodItem = new FoodItem()
                        {
                            Item_Name = eachItemProp[0],
                            Size_in_Kg = int.Parse(eachItemProp[1]),
                            Quantity = int.Parse(eachItemProp[2]),
                            Price = double.Parse(eachItemProp[3]),
                            Total = double.Parse(eachItemProp[4])
                        };
                        items.Add(foodItem);

                    }

                }
                else
                {
                    var eachItemProp = allItems.Split(';');

                    FoodItem foodItem = new FoodItem()
                    {
                        Item_Name = eachItemProp[0],
                        Size_in_Kg = int.Parse(eachItemProp[1]),
                        Quantity = int.Parse(eachItemProp[2]),
                        Price = double.Parse(eachItemProp[3]),
                        Total = double.Parse(eachItemProp[4])
                    };
                    items.Add(foodItem);
                }
                transaction.ItemsToSave = items;
                transactions.Add(transaction);
            }
            return transactions;
        }
        private Transaction LoadAllTransactionByID(string transId)
        {
            var alltransaction = LoadAllTransactions();
            return alltransaction.Where(t => t.TransactionId.Trim() == transId.Trim()).ToList().FirstOrDefault();
        }

        private List<Transaction> LoadAllTransactionByDate(string transDate)
        {
            var alltransaction = LoadAllTransactions();
            return alltransaction.Where(t => t.TransDate == transDate.Trim()).ToList();
        }
    }
}
