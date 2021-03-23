namespace AbioFoodsApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageTransaction = new System.Windows.Forms.Label();
            this.CompanyReceipt = new System.Windows.Forms.Label();
            this.TotalPizza = new System.Windows.Forms.Label();
            this.CompanyTransaction = new System.Windows.Forms.Label();
            this.CompanyAverageTransactionValue = new System.Windows.Forms.Label();
            this.TotalCompanyReciepts = new System.Windows.Forms.Label();
            this.TotalNumberPizza = new System.Windows.Forms.Label();
            this.TransactionLabel = new System.Windows.Forms.Label();
            this.AllSalesGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalAverageLabel = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.TransactionsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DaiyButton = new System.Windows.Forms.Button();
            this.AllSalesButton = new System.Windows.Forms.Button();
            this.SummaryGroupBox.SuspendLayout();
            this.AllSalesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.AverageTransaction);
            this.SummaryGroupBox.Controls.Add(this.CompanyReceipt);
            this.SummaryGroupBox.Controls.Add(this.TotalPizza);
            this.SummaryGroupBox.Controls.Add(this.CompanyTransaction);
            this.SummaryGroupBox.Controls.Add(this.CompanyAverageTransactionValue);
            this.SummaryGroupBox.Controls.Add(this.TotalCompanyReciepts);
            this.SummaryGroupBox.Controls.Add(this.TotalNumberPizza);
            this.SummaryGroupBox.Controls.Add(this.TransactionLabel);
            this.SummaryGroupBox.Location = new System.Drawing.Point(34, 11);
            this.SummaryGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SummaryGroupBox.Size = new System.Drawing.Size(464, 249);
            this.SummaryGroupBox.TabIndex = 9;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Daily Sales Summary";
            // 
            // AverageTransaction
            // 
            this.AverageTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AverageTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageTransaction.Location = new System.Drawing.Point(301, 203);
            this.AverageTransaction.Name = "AverageTransaction";
            this.AverageTransaction.Size = new System.Drawing.Size(132, 33);
            this.AverageTransaction.TabIndex = 9;
            this.AverageTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyReceipt
            // 
            this.CompanyReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyReceipt.Location = new System.Drawing.Point(301, 143);
            this.CompanyReceipt.Name = "CompanyReceipt";
            this.CompanyReceipt.Size = new System.Drawing.Size(132, 40);
            this.CompanyReceipt.TabIndex = 8;
            this.CompanyReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompanyReceipt.Click += new System.EventHandler(this.CompanyReceipt_Click);
            // 
            // TotalPizza
            // 
            this.TotalPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPizza.Location = new System.Drawing.Point(301, 89);
            this.TotalPizza.Name = "TotalPizza";
            this.TotalPizza.Size = new System.Drawing.Size(132, 40);
            this.TotalPizza.TabIndex = 7;
            this.TotalPizza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyTransaction
            // 
            this.CompanyTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTransaction.Location = new System.Drawing.Point(301, 34);
            this.CompanyTransaction.Name = "CompanyTransaction";
            this.CompanyTransaction.Size = new System.Drawing.Size(132, 40);
            this.CompanyTransaction.TabIndex = 6;
            this.CompanyTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyAverageTransactionValue
            // 
            this.CompanyAverageTransactionValue.AutoSize = true;
            this.CompanyAverageTransactionValue.Location = new System.Drawing.Point(36, 203);
            this.CompanyAverageTransactionValue.Name = "CompanyAverageTransactionValue";
            this.CompanyAverageTransactionValue.Size = new System.Drawing.Size(217, 23);
            this.CompanyAverageTransactionValue.TabIndex = 3;
            this.CompanyAverageTransactionValue.Text = "Avg Daily Transaction Value";
            // 
            // TotalCompanyReciepts
            // 
            this.TotalCompanyReciepts.AutoSize = true;
            this.TotalCompanyReciepts.Location = new System.Drawing.Point(36, 152);
            this.TotalCompanyReciepts.Name = "TotalCompanyReciepts";
            this.TotalCompanyReciepts.Size = new System.Drawing.Size(185, 23);
            this.TotalCompanyReciepts.TabIndex = 2;
            this.TotalCompanyReciepts.Text = "Daily Company Reciepts";
            // 
            // TotalNumberPizza
            // 
            this.TotalNumberPizza.AutoSize = true;
            this.TotalNumberPizza.Location = new System.Drawing.Point(36, 100);
            this.TotalNumberPizza.Name = "TotalNumberPizza";
            this.TotalNumberPizza.Size = new System.Drawing.Size(218, 23);
            this.TotalNumberPizza.TabIndex = 1;
            this.TotalNumberPizza.Text = "Total Number of Items Sold";
            // 
            // TransactionLabel
            // 
            this.TransactionLabel.AutoSize = true;
            this.TransactionLabel.Location = new System.Drawing.Point(36, 49);
            this.TransactionLabel.Name = "TransactionLabel";
            this.TransactionLabel.Size = new System.Drawing.Size(313, 23);
            this.TransactionLabel.TabIndex = 0;
            this.TransactionLabel.Text = "Total No of Transaction Processed Today";
            // 
            // AllSalesGroupBox
            // 
            this.AllSalesGroupBox.Controls.Add(this.TotalAverageLabel);
            this.AllSalesGroupBox.Controls.Add(this.TotalAmountLabel);
            this.AllSalesGroupBox.Controls.Add(this.ItemsLabel);
            this.AllSalesGroupBox.Controls.Add(this.TransactionsLabel);
            this.AllSalesGroupBox.Controls.Add(this.label5);
            this.AllSalesGroupBox.Controls.Add(this.label6);
            this.AllSalesGroupBox.Controls.Add(this.label7);
            this.AllSalesGroupBox.Controls.Add(this.label8);
            this.AllSalesGroupBox.Location = new System.Drawing.Point(34, 367);
            this.AllSalesGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllSalesGroupBox.Name = "AllSalesGroupBox";
            this.AllSalesGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllSalesGroupBox.Size = new System.Drawing.Size(464, 250);
            this.AllSalesGroupBox.TabIndex = 10;
            this.AllSalesGroupBox.TabStop = false;
            this.AllSalesGroupBox.Text = "All Sales Summary";
            this.AllSalesGroupBox.Enter += new System.EventHandler(this.AllSalesGroupBox_Enter);
            // 
            // TotalAverageLabel
            // 
            this.TotalAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAverageLabel.Location = new System.Drawing.Point(283, 200);
            this.TotalAverageLabel.Name = "TotalAverageLabel";
            this.TotalAverageLabel.Size = new System.Drawing.Size(136, 33);
            this.TotalAverageLabel.TabIndex = 9;
            this.TotalAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.Location = new System.Drawing.Point(283, 152);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(136, 40);
            this.TotalAmountLabel.TabIndex = 8;
            this.TotalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabel.Location = new System.Drawing.Point(283, 105);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(136, 40);
            this.ItemsLabel.TabIndex = 7;
            this.ItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactionsLabel
            // 
            this.TransactionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsLabel.Location = new System.Drawing.Point(283, 58);
            this.TransactionsLabel.Name = "TransactionsLabel";
            this.TransactionsLabel.Size = new System.Drawing.Size(136, 40);
            this.TransactionsLabel.TabIndex = 6;
            this.TransactionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Avg Transaction Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Company Reciepts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Number of Items Sold";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Company Trasaction";
            // 
            // DaiyButton
            // 
            this.DaiyButton.Location = new System.Drawing.Point(317, 280);
            this.DaiyButton.Name = "DaiyButton";
            this.DaiyButton.Size = new System.Drawing.Size(181, 36);
            this.DaiyButton.TabIndex = 11;
            this.DaiyButton.Text = "Show Daily Sales ";
            this.DaiyButton.UseVisualStyleBackColor = true;
            this.DaiyButton.Click += new System.EventHandler(this.DaiyButton_Click);
            // 
            // AllSalesButton
            // 
            this.AllSalesButton.Location = new System.Drawing.Point(317, 628);
            this.AllSalesButton.Name = "AllSalesButton";
            this.AllSalesButton.Size = new System.Drawing.Size(181, 36);
            this.AllSalesButton.TabIndex = 12;
            this.AllSalesButton.Text = "Show All Sales ";
            this.AllSalesButton.UseVisualStyleBackColor = true;
            this.AllSalesButton.Click += new System.EventHandler(this.AllSalesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 676);
            this.Controls.Add(this.AllSalesButton);
            this.Controls.Add(this.DaiyButton);
            this.Controls.Add(this.AllSalesGroupBox);
            this.Controls.Add(this.SummaryGroupBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Abio Food Sales Summary";
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.AllSalesGroupBox.ResumeLayout(false);
            this.AllSalesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label AverageTransaction;
        private System.Windows.Forms.Label CompanyReceipt;
        private System.Windows.Forms.Label TotalPizza;
        private System.Windows.Forms.Label CompanyTransaction;
        private System.Windows.Forms.Label CompanyAverageTransactionValue;
        private System.Windows.Forms.Label TotalCompanyReciepts;
        private System.Windows.Forms.Label TotalNumberPizza;
        private System.Windows.Forms.Label TransactionLabel;
        private System.Windows.Forms.GroupBox AllSalesGroupBox;
        private System.Windows.Forms.Label TotalAverageLabel;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label TransactionsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DaiyButton;
        private System.Windows.Forms.Button AllSalesButton;
    }
}