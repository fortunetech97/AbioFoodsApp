using AbioFoodsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbioFoodsApp.General
{
   public class Utility
    {
        public BindingList<UpdateItem> GetAllStoreItems()
        {
            BindingList<UpdateItem> UpdateItems = new BindingList<UpdateItem>();

            foreach (var line in File.ReadLines(AppSetting.UpdateFilData))
            {
                var eachItem = line.Split(';');

                var itemId = eachItem[0];

                var itemName = eachItem[1];
                var quantItem1kg = line.Split(';')[2];
                var quantItem3kg = line.Split(';')[3];
                var quantItem5kg = line.Split(';')[4];
                var quantItem7kg = line.Split(';')[5];
                var quantItem9kg = line.Split(';')[6];
                var quantItem10kg = line.Split(';')[7];



                UpdateItem updateitem = new UpdateItem()
                {
                    ItemId = int.Parse(itemId),
                    ItemName = itemName,
                    Quantity1Kg = int.Parse(quantItem1kg),
                    Quantity3Kg = int.Parse(quantItem3kg),
                    Quantity5Kg = int.Parse(quantItem5kg),
                    Quantity7Kg = int.Parse(quantItem7kg),
                    Quantity9Kg = int.Parse(quantItem9kg),
                    Quantity10Kg = int.Parse(quantItem10kg)

                };
                UpdateItems.Add(updateitem);
            }
            return UpdateItems;
        }
        public UpdateItem GetItemByItemName(string ItemName){
            try
            {
                return GetAllStoreItems().FirstOrDefault(i => i.ItemName.Trim().ToLowerInvariant() == ItemName.Trim().ToLowerInvariant());
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int GetItemQuantity(string Item, string Size)
        {
            int quantity=-1;
            try
            {
                Item = Item.Split(new string[] { "1kg" }, StringSplitOptions.None)[0];
                Size = Size.Replace("pack", "");
                Size = Size.Replace("kg", "");

                int sizeInInteger = int.Parse(Size);
                var allItems = GetAllStoreItems();
                foreach (var item in allItems)
                {
                    if (item.ItemName.Trim().ToLowerInvariant() == Item.Trim().ToLowerInvariant())
                    {
                        switch (sizeInInteger)
                        {
                            case 1:
                                {
                                    quantity= item.Quantity1Kg;
                                    break;
                                }
                            case 3:
                                {
                                    quantity=item.Quantity3Kg ;
                                    break;
                                }
                            case 5:
                                {
                                    quantity= item.Quantity5Kg;
                                    break;
                                }
                            case 7:
                                {
                                    quantity =item.Quantity7Kg ;
                                    break;
                                }
                            case 9:
                                {
                                    quantity= item.Quantity9Kg;
                                    break;
                                }
                            case 10:
                                {
                                    quantity=item.Quantity10Kg;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                }

            }
            catch (Exception e)
            {

                throw;
            }
            return quantity;
           }
        public void UpdateThisItem(string Item, string Size, int quantity, bool IsPostiveQuantity)
        {
        if(!IsPostiveQuantity){
                quantity = quantity * -1;
        }
            try
            {
                Item = Item.Split(new string[] { "1kg" }, StringSplitOptions.None)[0];
                Size = Size.Replace("pack", "");
                Size = Size.Replace("kg", "");

                int sizeInInteger = int.Parse(Size);
                var allItems = new Utility().GetAllStoreItems();



                foreach (var item in allItems)
                {
                    if (item.ItemName.Trim().ToLowerInvariant() == Item.Trim().ToLowerInvariant())
                    {
                        switch (sizeInInteger)
                        {
                            case 1:
                                {
                                    item.Quantity1Kg += quantity;
                                    break;
                                }
                            case 3:
                                {
                                    item.Quantity3Kg += quantity;
                                    break;
                                }
                            case 5:
                                {
                                    item.Quantity5Kg += quantity;
                                    break;
                                }
                            case 7:
                                {
                                    item.Quantity7Kg += quantity;
                                    break;
                                }
                            case 9:
                                {
                                    item.Quantity9Kg += quantity;
                                    break;
                                }
                            case 10:
                                {
                                    item.Quantity10Kg += quantity;
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                }
                //Update here
                string[] convertedItems = new string[allItems.Count()];

                foreach (var convertedItem in allItems)
                {
                    string stringItem = $"{convertedItem.ItemId};{convertedItem.ItemName};{convertedItem.Quantity1Kg};{convertedItem.Quantity3Kg};{convertedItem.Quantity5Kg};{convertedItem.Quantity7Kg};{convertedItem.Quantity9Kg};{convertedItem.Quantity10Kg}";
                    convertedItems[convertedItem.ItemId] = stringItem;
                }
                System.IO.File.WriteAllLines(AppSetting.UpdateFilData, convertedItems);
                FileStream obj = new FileStream(AppSetting.UpdateFilData, FileMode.Append);
                obj.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

        }
    }
}
