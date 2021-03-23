namespace AbioFoodsApp
{
    partial class StockReport2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.FoodItemsListBox = new System.Windows.Forms.ListBox();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 56;
            this.label2.Visible = false;
            // 
            // FoodItemsListBox
            // 
            this.FoodItemsListBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItemsListBox.FormattingEnabled = true;
            this.FoodItemsListBox.ItemHeight = 23;
            this.FoodItemsListBox.Items.AddRange(new object[] {
            "Poundo Yam             \t1kg @ $3.45",
            "Garri                         \t1kg @  4.33",
            "Honey Bean             \t1kg @ $3.45 ",
            "Yam Flour              \t1kg @ $4.53",
            "Melon Seed             \t1kg @ $2.23    ",
            "Agege Bread            \t1kg @ $2.56 ",
            "Mushroom             \t1kg @  $ 2.43",
            "Semo Vita          \t1kg @ $ 4.43       ",
            "Rice                      \t1kg @ $ 5.55   ",
            "Ogbono             \t1kg @  $ 2.43     ",
            "Yam          \t\t1kg @ $ 3.63",
            "African Potatoes  \t1kg @ $ 1.63",
            "Black Seed\t1kg @  $ 1.78"});
            this.FoodItemsListBox.Location = new System.Drawing.Point(111, 98);
            this.FoodItemsListBox.Name = "FoodItemsListBox";
            this.FoodItemsListBox.Size = new System.Drawing.Size(302, 142);
            this.FoodItemsListBox.TabIndex = 55;
            // 
            // SizeListBox
            // 
            this.SizeListBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeListBox.FormattingEnabled = true;
            this.SizeListBox.ItemHeight = 23;
            this.SizeListBox.Items.AddRange(new object[] {
            "1kg pack",
            "3kg pack",
            "5kg pack",
            "7kg pack",
            "9kg pack",
            "10kg pack"});
            this.SizeListBox.Location = new System.Drawing.Point(422, 98);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(148, 142);
            this.SizeListBox.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "Netweight:";
            this.label8.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "Items ";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Quantity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(852, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 40);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.ButtonTextbox_Click);
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Location = new System.Drawing.Point(111, 265);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.RowHeadersWidth = 62;
            this.ItemsGrid.RowTemplate.Height = 28;
            this.ItemsGrid.Size = new System.Drawing.Size(663, 292);
            this.ItemsGrid.TabIndex = 49;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(639, 98);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(133, 26);
            this.QuantityTextBox.TabIndex = 48;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(852, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 40);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StockReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 618);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FoodItemsListBox);
            this.Controls.Add(this.SizeListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ItemsGrid);
            this.Controls.Add(this.QuantityTextBox);
            this.Name = "StockReport2";
            this.Text = "StockReport2";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FoodItemsListBox;
        private System.Windows.Forms.ListBox SizeListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button btnAdd;
    }
}