using AbioFoodsApp.General;
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
    public partial class StockReport2 : Form
    {
        string UpdateFileData = Path.Combine(Environment.CurrentDirectory, "UpdateFileData.txt");
        BindingList<ItemToUpdate> itemsToSave = new BindingList<ItemToUpdate>();
        public StockReport2()
        {
            InitializeComponent();
        }

        private void ButtonTextbox_Click(object sender, EventArgs e)
        {
           
            try
            {
                foreach (var item in itemsToSave)
                {
                    new Utility().UpdateThisItem(item.Name, item.Size, item.Quantity, true);
                }
                itemsToSave = new BindingList<ItemToUpdate>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            MessageBox.Show("Item Updated Successfully");

        }
        public class ItemToUpdate{ 
         public string Name { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
          
           
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string Item = FoodItemsListBox.SelectedItem.ToString();
            string size = SizeListBox.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(Item))
            {
                MessageBox.Show("Please Select Item");
                return;
            }
            if (string.IsNullOrWhiteSpace(size))
            {
                MessageBox.Show("Please Select Size");
                return;
            }
            string quantity = QuantityTextBox.Text;
            int result;
            int.TryParse(quantity, out result);
            if (result < 1)
            {
                MessageBox.Show("Please Enter Quantity");
                return;
            }
            var item = new ItemToUpdate { Name = Item, Size = size, Quantity = result };
            itemsToSave.Add(item);
            ItemsGrid.DataSource = null;
            ItemsGrid.DataSource = itemsToSave;
        }
    }
}
