namespace AbioFoodsApp
{
    partial class Search
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
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.SecondSearchButton = new System.Windows.Forms.Button();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TransactionIDTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.button1);
            this.SearchGroupBox.Controls.Add(this.ItemsGrid);
            this.SearchGroupBox.Controls.Add(this.SecondSearchButton);
            this.SearchGroupBox.Controls.Add(this.DateTextBox);
            this.SearchGroupBox.Controls.Add(this.label22);
            this.SearchGroupBox.Controls.Add(this.TransactionIDTextBox);
            this.SearchGroupBox.Controls.Add(this.label21);
            this.SearchGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(132, 31);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(735, 471);
            this.SearchGroupBox.TabIndex = 22;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Sales Search";
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Location = new System.Drawing.Point(27, 113);
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.RowTemplate.Height = 28;
            this.ItemsGrid.Size = new System.Drawing.Size(679, 275);
            this.ItemsGrid.TabIndex = 37;
            // 
            // SecondSearchButton
            // 
            this.SecondSearchButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondSearchButton.Location = new System.Drawing.Point(123, 77);
            this.SecondSearchButton.Name = "SecondSearchButton";
            this.SecondSearchButton.Size = new System.Drawing.Size(90, 30);
            this.SecondSearchButton.TabIndex = 26;
            this.SecondSearchButton.Text = "Search";
            this.SecondSearchButton.UseVisualStyleBackColor = true;
            this.SecondSearchButton.Click += new System.EventHandler(this.SecondSearchButton_Click);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(201, 45);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(121, 26);
            this.DateTextBox.TabIndex = 24;
            this.DateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Control;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(151, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 23);
            this.label22.TabIndex = 25;
            this.label22.Text = "Date:";
            // 
            // TransactionIDTextBox
            // 
            this.TransactionIDTextBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionIDTextBox.Location = new System.Drawing.Point(201, 15);
            this.TransactionIDTextBox.Name = "TransactionIDTextBox";
            this.TransactionIDTextBox.Size = new System.Drawing.Size(121, 30);
            this.TransactionIDTextBox.TabIndex = 22;
            this.TransactionIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Control;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(74, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 23);
            this.label21.TabIndex = 23;
            this.label21.Text = "Transaction ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 542);
            this.Controls.Add(this.SearchGroupBox);
            this.Name = "Search";
            this.Text = "Search";
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.DataGridView ItemsGrid;
        private System.Windows.Forms.Button SecondSearchButton;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TransactionIDTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
    }
}