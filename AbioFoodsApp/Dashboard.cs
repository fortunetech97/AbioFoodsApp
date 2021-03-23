using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AbioFoodsApp.Models;
using AbioFoodsApp.General;

namespace AbioFoodsApp
{
    public partial class MainForm : Form
    {
        private string itemNameSelected = string.Empty;
        private double itemPriceSelected = 0;
        private BindingList<FoodItem> selectedFoodItems = new BindingList<FoodItem>();
        private Transaction trans = new Transaction();
        private string wholeTransaction = string.Empty;
        bool trasaction;

        string TrasactionFileData = Path.Combine(Environment.CurrentDirectory, "TrasactionFileData.txt");
        string UpdateFileData = Path.Combine(Environment.CurrentDirectory, "UpdateFileData.txt");

        public MainForm()
        {
            InitializeComponent();

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            label1.Visible = true; ItemsGrid.Visible = true; panel1.Visible = true; SizeListBox.Visible = true; OtherOptionGroupBox.Visible = true;
            AddButton2.Visible = true; FoodItemsListBox.Visible = true; POSGroupox.Visible = true; ListOfOrderGroupBox.Visible = true;
            SalesSummaryGroupBox.Visible = true; label8.Visible = true;

            trasaction = true;
        }


        //Add items to DataGrid
        private void AddButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (FoodItemsListBox.SelectedItem != null && SizeListBox != null && BigBagRadioButton.Checked == true || FoodItemsListBox.SelectedItem != null && SizeListBox != null && SmallBagRadioButton.Checked == true)
                {
                    MessageBox.Show("More than one item can not be selected");
                    FoodItemsListBox.SelectedItem = null;
                    SizeListBox.SelectedItem = null;
                    BigBagRadioButton.Checked = false;
                    SmallBagRadioButton.Checked = false;
                    return;
                }
                else
                {
                    string itemName = itemNameSelected;
                    double price = double.Parse(NoOfItemLabel.Text);

                    //if (string.IsNullOrWhiteSpace(itemName) || price < 1)
                    //{
                    //    MessageBox.Show("Item is not Selected");
                    //    return;
                    //}
                    int result;
                    int.TryParse(QuantityTextBox.Text, out result);
                    if (result < 1)
                    {
                        MessageBox.Show("Quantity is Required");
                        return;
                    }
                if (FoodItemsListBox.SelectedIndex > 0)
                {
                    string itemSelected = FoodItemsListBox.SelectedItem.ToString();
                    string itemPackSelected = SizeListBox.SelectedItem.ToString();



                    // var item = LoaditembyId(index);
                    var quant = new Utility().GetItemQuantity(itemSelected, itemPackSelected);

                    //labelDate.Text = quantity.ToString();
                    int QuantEnter = int.Parse(QuantityTextBox.Text);
                    if (QuantEnter > quant)
                    {
                        MessageBox.Show("The available goods is not up to the number of quantity entered");
                        return;
                    }
                    
                }
                    int itemQuantity = int.Parse(QuantityTextBox.Text);
                    double totalPrice = price * itemQuantity;
                    TotalLabel.Text = totalPrice.ToString();
                    if (BigBagRadioButton.Checked == true)
                    {
                        int quantity = int.Parse(QuantityTextBox.Text);
                        double total = price * quantity;
                        FoodItem newItem2 = new FoodItem { Item_Name = "Big Shopping Bag", Price = price, Size_in_Kg = 0, Quantity = quantity, Total = total };
                        selectedFoodItems.Add(newItem2);
                        ItemsGrid.DataSource = null;
                        ItemsGrid.DataSource = selectedFoodItems;
                    return;
                    }
                    else if (SmallBagRadioButton.Checked == true)
                    {
                        int quantity = int.Parse(QuantityTextBox.Text);
                        double total = price * quantity;
                        FoodItem newItem2 = new FoodItem { Item_Name = "Small Shopping Bag", Price = price, Size_in_Kg = 0, Quantity = quantity, Total = total };
                        selectedFoodItems.Add(newItem2);
                        ItemsGrid.DataSource = null;
                        ItemsGrid.DataSource = selectedFoodItems;
                    return;
                    }

                    else
                    {
                        FoodItem newItem = new FoodItem { Item_Name = itemName, Price = price, Size_in_Kg = GetNetweightSize(), Quantity = itemQuantity, Total = totalPrice };

                        selectedFoodItems.Add(newItem);
                        ItemsGrid.DataSource = null;

                        ItemsGrid.DataSource = selectedFoodItems;

                        // QuantityTextBox.Text = "1";
                        if (string.IsNullOrEmpty(QuantityTextBox.Text))
                        {
                            QuantityTextBox.Text = "1";
                        }

                        //update quatity
                        #region update quantity
                        if (FoodItemsListBox.SelectedItem !=null && SizeListBox.SelectedItem != null)
                        {
                            string quantityEnter = QuantityTextBox.Text;
                            int quantity;
                            int.TryParse(quantityEnter, out quantity);
                            if(quantity<1){
                                MessageBox.Show("Please Enter Quantity");
                                return;
                            }
                            new Utility().UpdateThisItem(FoodItemsListBox.SelectedItem.ToString(), SizeListBox.SelectedItem.ToString(), quantity, false);
                        }
                       
                       
                        #endregion


                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            NoOfItemLabel.Text = "";
            TotalLabel.Text = "";
            SizeListBox.SelectedIndex = -1;
            FoodItemsListBox.SelectedIndex = -1;
            SalesSummaryGroupBox.Enabled = false;
            SizeListBox.Enabled = false;

            if (trasaction == true)
            {
                SalesIDLabel.Text = RandomNo();
                DateLabel.Text = DateTime.Now.ToShortDateString();
                trasaction = false;
            }

            double GrandTotal = 0;
            foreach (var item in selectedFoodItems)
            {
                GrandTotal += item.Total;
                //TotalItemsLabel.Text = null;
                TotalItemsLabel.Text = GrandTotal.ToString();
            }

        }

        //Get item name and price from selected item in the item listbox
        private void FoodItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (FoodItemsListBox.SelectedIndex >= 0)
                {
                    var itemSelected = FoodItemsListBox.SelectedItem.ToString();
                    string Name = itemSelected.Split('@')[0];
                    itemNameSelected = Name;
                    string Price = itemSelected.Split('@')[1].Replace('$', ' ');
                    itemPriceSelected = Double.Parse(Price.Trim());

                    SizeListBox.Enabled = true;
                    BigBagRadioButton.Checked = false;
                    SmallBagRadioButton.Checked = false;
                    Refresh();
                }
                else
                {
                    FoodItemsListBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //GetNetweightPrice
        private double GetNetweightPrice(double ItemPrice)
        {
            double totalsizePrice = 0;
            int NetweightIndex = SizeListBox.SelectedIndex;
            switch (NetweightIndex)
            {
                case 0:
                    totalsizePrice = ItemPrice * 1;
                    //return totalsizePrice;
                    break;
                case 1:
                    totalsizePrice = ItemPrice * 3;
                    break;
                case 2:
                    totalsizePrice = ItemPrice * 5;
                    break;
                case 3:
                    totalsizePrice = ItemPrice * 7;
                    break;
                case 4:
                    totalsizePrice = ItemPrice * 9;
                    break;
                case 5:
                    totalsizePrice = ItemPrice * 10;
                    break;
            }
            return totalsizePrice;
        }

        private int GetNetweightSize()
        {
            int size = 1;
            int NetweightIndex = SizeListBox.SelectedIndex;
            switch (NetweightIndex)
            {
                case 0:
                    size = 1;                   
                    break;
                case 1:
                    size = 3;
                    break;
                case 2:
                    size = 5;
                    break;
                case 3:
                    size = 7;
                    break;
                case 4:
                    size = 9;
                    break;
                case 5:
                    size = 10;
                    break;
            }
            return size;
        }


        private void SizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                SalesSummaryGroupBox.Enabled = true;

                BigBagRadioButton.Checked = false;
                SmallBagRadioButton.Checked = false;
                double PricePerItem;
                PricePerItem = GetNetweightPrice(itemPriceSelected);
                NoOfItemLabel.Text = PricePerItem.ToString();
                double totalprice = double.Parse(QuantityTextBox.Text) * double.Parse(NoOfItemLabel.Text);
                TotalLabel.Text = totalprice.ToString();
                QuantityTextBox.Text = "1";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refresh()
        {
            NoOfItemLabel.Text = "";
            QuantityTextBox.Text = "1";
        }
        private void BigBagRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            NoOfItemLabel.Text = "3";
            QuantityTextBox.Text = "1";
            TotalLabel.Text = "";
            SalesSummaryGroupBox.Enabled = true;
            TotalLabel.Text = (int.Parse(QuantityTextBox.Text) * double.Parse(NoOfItemLabel.Text)).ToString();
        }

        private void SmallBagRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            Refresh();
            
            NoOfItemLabel.Text = "2";
            QuantityTextBox.Text = "1";
            TotalLabel.Text = "";
            SalesSummaryGroupBox.Enabled = true;
            
            TotalLabel.Text = (int.Parse(QuantityTextBox.Text) * double.Parse(NoOfItemLabel.Text)).ToString();
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                double totalprice = double.Parse(QuantityTextBox.Text) * double.Parse(NoOfItemLabel.Text);
                TotalLabel.Text = totalprice.ToString();
            }
            catch (Exception ex)
            {
                QuantityTextBox.Text = "";
            }
        }

        private string RandomNo()
        {
            Random rnd = new Random();
            int a = Convert.ToInt32(rnd.Next(0, 9));
            int b = Convert.ToInt32(rnd.Next(0, 9));
            int c = Convert.ToInt32(rnd.Next(0, 9));
            int d = Convert.ToInt32(rnd.Next(0, 9));
            int f = Convert.ToInt32(rnd.Next(0, 9));
            int g = Convert.ToInt32(rnd.Next(0, 9));
            string id = a.ToString() + b.ToString() + c.ToString() + d.ToString() + g.ToString() + f.ToString();

            return id;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            selectedFoodItems = new BindingList<FoodItem>();
            ItemsGrid.DataSource = null;
            trasaction = true;
            QuantityTextBox.Text = "1";
            NoOfItemLabel.Text = "";
            FoodItemsListBox.Enabled = true;
            SizeListBox.Enabled = true;
            OtherOptionGroupBox.Enabled = true;
            SalesSummaryGroupBox.Enabled = true;

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            trans = new Transaction()
            {

                ItemsToSave = selectedFoodItems,
                TransactionId = SalesIDLabel.Text,
                Total = TotalItemsLabel.Text,
                TransDate = DateLabel.Text
            };
            if (string.IsNullOrWhiteSpace(trans.TransactionId))
            {
                MessageBox.Show("Order Already Confirmed, Please Click New Order");
                return;
            }
            if (!trans.ItemsToSave.Any())
            {
                MessageBox.Show("Please Select Food Item");
                return;
            }
            using (TextWriter writer = new StreamWriter(TrasactionFileData, true))
            {
                wholeTransaction = trans.TransactionId + ";" + trans.TransDate + ";" + trans.Total + "#";

                // string itemName;
                foreach (var item in selectedFoodItems)
                {

                    wholeTransaction += item.Item_Name + ";" + item.Size_in_Kg + ";" + item.Quantity + ";" + item.Price + ";" + item.Total + "$";
                }
                wholeTransaction = wholeTransaction.Substring(0, wholeTransaction.Length - 1);
                wholeTransaction += "\n";

                string MsgwholeTransaction = "";
                foreach (var item in selectedFoodItems)
                {

                    MsgwholeTransaction += item.Item_Name + "," + " " + item.Size_in_Kg + "," + " " + item.Quantity + "," + " " + item.Price + "," + " " + item.Total + "\n";
                }
                DialogResult dialogresult = MessageBox.Show("Transaction ID = " + trans.TransactionId + "\n" + "You have choosen the following items" + "\n" + MsgwholeTransaction + "\n" + "The total cost of all the items is = " + trans.Total + "\n" + "Do you wish to proceed?", "Sales Confirmation", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {

                    //Save membership details into the file text.
                    writer.Write(wholeTransaction);

                    ClearData(trans, wholeTransaction);
                }
                else if (dialogresult == DialogResult.No)
                {
                    ;
                }

            }
           
        }
        //clear all the selected items 
        private void ClearData(Transaction trans, string wholeTransaction)
        {
            selectedFoodItems = new BindingList<FoodItem>();
            trans = new Transaction();
            SalesIDLabel.Text = "";
            TotalItemsLabel.Text = "";
            wholeTransaction = "";
            ItemsGrid.DataSource = null;
            FoodItemsListBox.Enabled = false;
            OtherOptionGroupBox.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void OtherOptionGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                ClearData(trans, wholeTransaction);
            }
            else
            {
                ;
            }
        }

        //show sales summary form
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            Form1 salesSummaryForm = new Form1();
            salesSummaryForm.Show();
            SalesSummaryGroupBox.Visible = true;
        }

        //show saarch form
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StockReport2 StockReportForm = new StockReport2();
            StockReportForm.ShowDialog();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Remove item from datagrid
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in ItemsGrid.SelectedRows)
            {
                ItemsGrid.Rows.RemoveAt(item.Index);
            }

            double GrandTotal = 0;
            foreach (var item in selectedFoodItems)
            {
                GrandTotal += item.Total;

                TotalItemsLabel.Text = GrandTotal.ToString();
            }

        }


        //Get all item in UpdateTextFile
        public BindingList<StoreItem> GetStoreItems()
        {
            BindingList<StoreItem> StoreItems = new BindingList<StoreItem>();

            foreach (var line in File.ReadLines(UpdateFileData))
            {
                var ItemsId = line.Split(';')[0];
                var ItemsName = line.Split(';')[1];
                var price = line.Split(';')[2];
                var quantity = line.Split(';')[3];
                StoreItem storeitem = new StoreItem()
                {
                    ItemId = int.Parse(ItemsId),

                    Price = price,
                    ItemName = ItemsName + " " + "1kg @ " + price,
                    Quantity = int.Parse(quantity)
                };
                StoreItems.Add(storeitem);


            }

            return StoreItems;
        }


        public StoreItem LoaditembyId(int id)
        {
            var allitem = GetStoreItems();
            return allitem.Where(a => a.ItemId == id).ToList().FirstOrDefault();
        }

        

        public class StoreItem
        {
            public int ItemId { get; set; }
            public string ItemName { get; set; }
            public string Price { get; set; }
            public int Quantity { get; set; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void test_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();      
        }
    }
}
