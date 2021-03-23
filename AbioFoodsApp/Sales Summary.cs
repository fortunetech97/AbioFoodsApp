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
    public partial class Form1 : Form
    {
        string TransactionFileData = Path.Combine(Environment.CurrentDirectory, "TrasactionFileData.txt");
       // private BindingList<Transaction> transactions = new BindingList<Transaction>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AllSalesGroupBox_Enter(object sender, EventArgs e)
        {

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
                  if(!allItems.Contains("$")){
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
                //transactions = new BindingList<Transaction>();
                transactions.Add(transaction);
            }
            return transactions;
        }
      

        private Transaction LoadAllTransactionByID(string transId)
        {
            
            var alltransaction = LoadAllTransactions();
            return alltransaction.Where(t => t.TransactionId.Trim() == transId.Trim()).ToList().FirstOrDefault();
        }
        private Tuple<int,int> TransAndItems(string transdate="")
        {
            //total no of trasaction by date
            
            var alltransaction = LoadAllTransactions();
            int totalItems = 0;
            int totalTrans = 0;
            if (string.IsNullOrWhiteSpace(transdate)){

                totalTrans = alltransaction.Count();

                foreach (var item in alltransaction)
                {
                    totalItems += item.ItemsToSave.Count();
                }

                return new Tuple<int, int>(totalTrans, totalItems);
            }
            var transactionByDate = alltransaction.Where(t => t.TransDate.Trim() == transdate.Trim());
             totalTrans = transactionByDate.Count();
          
            foreach (var item in transactionByDate)
            {
                totalItems += item.ItemsToSave.Count();
            }

            return new Tuple<int, int>(totalTrans, totalItems);
        }

        
       
        private double LoadTotalAmountByDate(string date="")
        {
            //total no of trasaction by date
            double Tamt = 0;
            var alltransaction = LoadAllTransactions();

            var alltrans = new List<Transaction>();
            if (string.IsNullOrWhiteSpace(date)){
                 alltrans = alltransaction.ToList();
            }else{
                alltrans = alltransaction.Where(t => t.TransDate.Trim() == date.Trim()).ToList();
            }
             
            //alltrans.Count();
            foreach (var amt in alltrans )
                {
                    Tamt += double.Parse(amt.Total);
            }
            return Tamt;
        }

        private void DaiyButton_Click(object sender, EventArgs e)
        {
             string date = DateTime.Now.ToShortDateString();
            var Tamt = LoadTotalAmountByDate(date);
            if (Tamt < 1)
            {
                MessageBox.Show("No record found for today");
            }
            else
            {
                //  string date = "1/7/2021";


                var transItems = TransAndItems(date);

                CompanyTransaction.Text = transItems.Item1.ToString();
                TotalPizza.Text = transItems.Item2.ToString();

                CompanyReceipt.Text = LoadTotalAmountByDate(date).ToString();

                int totalitem = int.Parse(TotalPizza.Text);
                double price = double.Parse(CompanyReceipt.Text);
                double ave = price / totalitem;
                AverageTransaction.Text = ave.ToString();
             }
            }

        private void Ttrans_Click(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToShortDateString();
            //CompanyTransaction.Text = LoadAllTransactionByDate(date).ToString();
        }

        private void Titems_Click(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToShortDateString();
            //TotalPizza.Text = LoadAllItemsByDate(date).ToString();
        }

        private void CompanyReceipt_Click(object sender, EventArgs e)
        {

        }

        private void AllSalesButton_Click(object sender, EventArgs e)
        {
            var Tamt = LoadTotalAmountByDate();
            if (Tamt < 1)
            {
                MessageBox.Show("No record found");
            }
            else
            {
                var transItems = TransAndItems();
                TransactionsLabel.Text = transItems.Item1.ToString();
                ItemsLabel.Text = transItems.Item2.ToString();
                TotalAmountLabel.Text = LoadTotalAmountByDate().ToString();

                int totalitem = int.Parse(ItemsLabel.Text);
                double price = double.Parse(TotalAmountLabel.Text);
                double ave = price / totalitem;
                TotalAverageLabel.Text = ave.ToString();
            }
        }
    }
}
