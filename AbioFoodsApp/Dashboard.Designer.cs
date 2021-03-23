namespace AbioFoodsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.SalesIDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.ListOfOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NoOfItemLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.OtherOptionGroupBox = new System.Windows.Forms.GroupBox();
            this.NoShopingBagRdb = new System.Windows.Forms.RadioButton();
            this.SmallBagRadioButton = new System.Windows.Forms.RadioButton();
            this.BigBagRadioButton = new System.Windows.Forms.RadioButton();
            this.POSGroupox = new System.Windows.Forms.GroupBox();
            this.FoodItemsListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.ListOfOrderGroupBox.SuspendLayout();
            this.SalesSummaryGroupBox.SuspendLayout();
            this.OtherOptionGroupBox.SuspendLayout();
            this.POSGroupox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(10, 258);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(129, 33);
            this.SearchButton.TabIndex = 22;
            this.SearchButton.Text = "Search";
            this.toolTip1.SetToolTip(this.SearchButton, "This add new item(s)");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoveButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(10, 53);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(129, 33);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove Item";
            this.toolTip1.SetToolTip(this.RemoveButton, "The remove items from the list ");
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SummaryButton);
            this.panel1.Controls.Add(this.AddButton2);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.ConfirmButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Location = new System.Drawing.Point(784, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 424);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 33);
            this.button2.TabIndex = 36;
            this.button2.Text = "Refresh";
            this.toolTip1.SetToolTip(this.button2, "The exit the application");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Stock Report";
            this.toolTip1.SetToolTip(this.button1, "This display the company stock report in new form");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SummaryButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(10, 217);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(129, 33);
            this.SummaryButton.TabIndex = 29;
            this.SummaryButton.Text = "Sales Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "This display total sales summary of the company");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // AddButton2
            // 
            this.AddButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddButton2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton2.Location = new System.Drawing.Point(10, 12);
            this.AddButton2.Name = "AddButton2";
            this.AddButton2.Size = new System.Drawing.Size(129, 33);
            this.AddButton2.TabIndex = 35;
            this.AddButton2.Text = "Add";
            this.AddButton2.UseVisualStyleBackColor = true;
            this.AddButton2.Visible = false;
            this.AddButton2.Click += new System.EventHandler(this.AddButton2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(10, 376);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 33);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.Text = "Exit";
            this.toolTip1.SetToolTip(this.ExitButton, "The exit the application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ConfirmButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(10, 94);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(129, 33);
            this.ConfirmButton.TabIndex = 24;
            this.ConfirmButton.Text = "Confirm Order";
            this.toolTip1.SetToolTip(this.ConfirmButton, "This confirrm the item(s) bought and save records ");
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Location = new System.Drawing.Point(10, 176);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(129, 33);
            this.NewButton.TabIndex = 26;
            this.NewButton.Text = "New Order";
            this.toolTip1.SetToolTip(this.NewButton, "This clear dashboard for new sales");
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(10, 135);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(129, 33);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel Order";
            this.toolTip1.SetToolTip(this.CancelButton, "This cancel order ");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartButton.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartButton.Location = new System.Drawing.Point(499, 131);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(81, 29);
            this.StartButton.TabIndex = 34;
            this.StartButton.Text = "&Start";
            this.toolTip1.SetToolTip(this.StartButton, "Please press to start the sales of the day");
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(337, 29);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(104, 23);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Transaction ID:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(225, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thanks for shopping @ Abio Food";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Location = new System.Drawing.Point(20, 55);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.RowHeadersWidth = 62;
            this.ItemsGrid.RowTemplate.Height = 28;
            this.ItemsGrid.Size = new System.Drawing.Size(660, 279);
            this.ItemsGrid.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(272, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Date:";
            // 
            // SalesIDLabel
            // 
            this.SalesIDLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalesIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesIDLabel.Location = new System.Drawing.Point(145, 28);
            this.SalesIDLabel.Name = "SalesIDLabel";
            this.SalesIDLabel.Size = new System.Drawing.Size(104, 23);
            this.SalesIDLabel.TabIndex = 5;
            this.SalesIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total of Items";
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalItemsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLabel.Location = new System.Drawing.Point(563, 25);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(104, 23);
            this.TotalItemsLabel.TabIndex = 12;
            this.TotalItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListOfOrderGroupBox
            // 
            this.ListOfOrderGroupBox.Controls.Add(this.TotalItemsLabel);
            this.ListOfOrderGroupBox.Controls.Add(this.label3);
            this.ListOfOrderGroupBox.Controls.Add(this.SalesIDLabel);
            this.ListOfOrderGroupBox.Controls.Add(this.label11);
            this.ListOfOrderGroupBox.Controls.Add(this.ItemsGrid);
            this.ListOfOrderGroupBox.Controls.Add(this.label6);
            this.ListOfOrderGroupBox.Controls.Add(this.label10);
            this.ListOfOrderGroupBox.Controls.Add(this.DateLabel);
            this.ListOfOrderGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfOrderGroupBox.Location = new System.Drawing.Point(15, 208);
            this.ListOfOrderGroupBox.Name = "ListOfOrderGroupBox";
            this.ListOfOrderGroupBox.Size = new System.Drawing.Size(755, 362);
            this.ListOfOrderGroupBox.TabIndex = 39;
            this.ListOfOrderGroupBox.TabStop = false;
            this.ListOfOrderGroupBox.Text = "List Of Order";
            this.ListOfOrderGroupBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Items ";
            this.label1.Visible = false;
            // 
            // SalesSummaryGroupBox
            // 
            this.SalesSummaryGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesSummaryGroupBox.Controls.Add(this.TotalLabel);
            this.SalesSummaryGroupBox.Controls.Add(this.label5);
            this.SalesSummaryGroupBox.Controls.Add(this.QuantityTextBox);
            this.SalesSummaryGroupBox.Controls.Add(this.label13);
            this.SalesSummaryGroupBox.Controls.Add(this.NoOfItemLabel);
            this.SalesSummaryGroupBox.Controls.Add(this.label9);
            this.SalesSummaryGroupBox.Enabled = false;
            this.SalesSummaryGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesSummaryGroupBox.Location = new System.Drawing.Point(563, 30);
            this.SalesSummaryGroupBox.Name = "SalesSummaryGroupBox";
            this.SalesSummaryGroupBox.Size = new System.Drawing.Size(182, 146);
            this.SalesSummaryGroupBox.TabIndex = 32;
            this.SalesSummaryGroupBox.TabStop = false;
            this.SalesSummaryGroupBox.Text = "Sales Summary";
            this.SalesSummaryGroupBox.Visible = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(104, 99);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(69, 24);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total ";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(102, 62);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(71, 30);
            this.QuantityTextBox.TabIndex = 10;
            this.QuantityTextBox.Text = "1";
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTextBox.WordWrap = false;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Quantity:";
            // 
            // NoOfItemLabel
            // 
            this.NoOfItemLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoOfItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NoOfItemLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfItemLabel.Location = new System.Drawing.Point(102, 30);
            this.NoOfItemLabel.Name = "NoOfItemLabel";
            this.NoOfItemLabel.Size = new System.Drawing.Size(71, 26);
            this.NoOfItemLabel.TabIndex = 1;
            this.NoOfItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price per Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Netweight:";
            this.label8.Visible = false;
            // 
            // SizeListBox
            // 
            this.SizeListBox.Enabled = false;
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
            this.SizeListBox.Location = new System.Drawing.Point(218, 64);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(100, 73);
            this.SizeListBox.TabIndex = 37;
            this.SizeListBox.Visible = false;
            this.SizeListBox.SelectedIndexChanged += new System.EventHandler(this.SizeListBox_SelectedIndexChanged);
            // 
            // OtherOptionGroupBox
            // 
            this.OtherOptionGroupBox.Controls.Add(this.NoShopingBagRdb);
            this.OtherOptionGroupBox.Controls.Add(this.SmallBagRadioButton);
            this.OtherOptionGroupBox.Controls.Add(this.BigBagRadioButton);
            this.OtherOptionGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherOptionGroupBox.Location = new System.Drawing.Point(329, 28);
            this.OtherOptionGroupBox.Name = "OtherOptionGroupBox";
            this.OtherOptionGroupBox.Size = new System.Drawing.Size(228, 148);
            this.OtherOptionGroupBox.TabIndex = 38;
            this.OtherOptionGroupBox.TabStop = false;
            this.OtherOptionGroupBox.Text = "Shopping Bag";
            this.OtherOptionGroupBox.Visible = false;
            this.OtherOptionGroupBox.Enter += new System.EventHandler(this.OtherOptionGroupBox_Enter);
            // 
            // NoShopingBagRdb
            // 
            this.NoShopingBagRdb.AutoSize = true;
            this.NoShopingBagRdb.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoShopingBagRdb.Location = new System.Drawing.Point(5, 95);
            this.NoShopingBagRdb.Name = "NoShopingBagRdb";
            this.NoShopingBagRdb.Size = new System.Drawing.Size(158, 27);
            this.NoShopingBagRdb.TabIndex = 2;
            this.NoShopingBagRdb.TabStop = true;
            this.NoShopingBagRdb.Text = "No Shopping Bag";
            this.NoShopingBagRdb.UseVisualStyleBackColor = true;
            this.NoShopingBagRdb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SmallBagRadioButton
            // 
            this.SmallBagRadioButton.AutoSize = true;
            this.SmallBagRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallBagRadioButton.Location = new System.Drawing.Point(5, 65);
            this.SmallBagRadioButton.Name = "SmallBagRadioButton";
            this.SmallBagRadioButton.Size = new System.Drawing.Size(222, 27);
            this.SmallBagRadioButton.TabIndex = 1;
            this.SmallBagRadioButton.TabStop = true;
            this.SmallBagRadioButton.Text = "Small Shopping Bag @ €2";
            this.SmallBagRadioButton.UseVisualStyleBackColor = true;
            this.SmallBagRadioButton.CheckedChanged += new System.EventHandler(this.SmallBagRadioButton_CheckedChanged);
            // 
            // BigBagRadioButton
            // 
            this.BigBagRadioButton.AutoSize = true;
            this.BigBagRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BigBagRadioButton.Location = new System.Drawing.Point(5, 34);
            this.BigBagRadioButton.Name = "BigBagRadioButton";
            this.BigBagRadioButton.Size = new System.Drawing.Size(205, 27);
            this.BigBagRadioButton.TabIndex = 0;
            this.BigBagRadioButton.TabStop = true;
            this.BigBagRadioButton.Text = "Big Shopping bag @ €3";
            this.BigBagRadioButton.UseVisualStyleBackColor = true;
            this.BigBagRadioButton.CheckedChanged += new System.EventHandler(this.BigBagRadioButton_CheckedChanged);
            // 
            // POSGroupox
            // 
            this.POSGroupox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.POSGroupox.Controls.Add(this.FoodItemsListBox);
            this.POSGroupox.Controls.Add(this.OtherOptionGroupBox);
            this.POSGroupox.Controls.Add(this.SizeListBox);
            this.POSGroupox.Controls.Add(this.label8);
            this.POSGroupox.Controls.Add(this.SalesSummaryGroupBox);
            this.POSGroupox.Controls.Add(this.label1);
            this.POSGroupox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSGroupox.Location = new System.Drawing.Point(12, 12);
            this.POSGroupox.Name = "POSGroupox";
            this.POSGroupox.Size = new System.Drawing.Size(758, 187);
            this.POSGroupox.TabIndex = 38;
            this.POSGroupox.TabStop = false;
            this.POSGroupox.Text = "Point of Sales ";
            this.POSGroupox.Visible = false;
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
            this.FoodItemsListBox.Location = new System.Drawing.Point(15, 64);
            this.FoodItemsListBox.Name = "FoodItemsListBox";
            this.FoodItemsListBox.Size = new System.Drawing.Size(198, 73);
            this.FoodItemsListBox.TabIndex = 39;
            this.FoodItemsListBox.Visible = false;
            this.FoodItemsListBox.SelectedIndexChanged += new System.EventHandler(this.FoodItemsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 593);
            this.Controls.Add(this.POSGroupox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ListOfOrderGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Abio Foods ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ListOfOrderGroupBox.ResumeLayout(false);
            this.ListOfOrderGroupBox.PerformLayout();
            this.SalesSummaryGroupBox.ResumeLayout(false);
            this.SalesSummaryGroupBox.PerformLayout();
            this.OtherOptionGroupBox.ResumeLayout(false);
            this.OtherOptionGroupBox.PerformLayout();
            this.POSGroupox.ResumeLayout(false);
            this.POSGroupox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AddButton2;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label SalesIDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.GroupBox ListOfOrderGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SalesSummaryGroupBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label NoOfItemLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox SizeListBox;
        private System.Windows.Forms.GroupBox OtherOptionGroupBox;
        private System.Windows.Forms.RadioButton NoShopingBagRdb;
        private System.Windows.Forms.RadioButton SmallBagRadioButton;
        private System.Windows.Forms.RadioButton BigBagRadioButton;
        private System.Windows.Forms.GroupBox POSGroupox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox FoodItemsListBox;
    }
}

