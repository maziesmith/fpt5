namespace BookStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookTitleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookPriceTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookQuantityTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTitleTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookID";
            // 
            // bookIdTxt
            // 
            this.bookIdTxt.Location = new System.Drawing.Point(88, 10);
            this.bookIdTxt.Name = "bookIdTxt";
            this.bookIdTxt.Size = new System.Drawing.Size(154, 20);
            this.bookIdTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BookTitle";
            // 
            // bookTitleTxt
            // 
            this.bookTitleTxt.Location = new System.Drawing.Point(88, 35);
            this.bookTitleTxt.Name = "bookTitleTxt";
            this.bookTitleTxt.Size = new System.Drawing.Size(154, 20);
            this.bookTitleTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "BookPrice";
            // 
            // bookPriceTxt
            // 
            this.bookPriceTxt.Location = new System.Drawing.Point(88, 60);
            this.bookPriceTxt.Name = "bookPriceTxt";
            this.bookPriceTxt.Size = new System.Drawing.Size(154, 20);
            this.bookPriceTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "BookQuantity";
            // 
            // bookQuantityTxt
            // 
            this.bookQuantityTxt.Location = new System.Drawing.Point(88, 86);
            this.bookQuantityTxt.Name = "bookQuantityTxt";
            this.bookQuantityTxt.Size = new System.Drawing.Size(154, 20);
            this.bookQuantityTxt.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(16, 119);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(97, 119);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(178, 119);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(259, 119);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // bookGrid
            // 
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Location = new System.Drawing.Point(13, 149);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.Size = new System.Drawing.Size(483, 226);
            this.bookGrid.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter title:";
            // 
            // searchTitleTxt
            // 
            this.searchTitleTxt.Location = new System.Drawing.Point(73, 382);
            this.searchTitleTxt.Name = "searchTitleTxt";
            this.searchTitleTxt.Size = new System.Drawing.Size(154, 20);
            this.searchTitleTxt.TabIndex = 5;
            this.searchTitleTxt.TextChanged += new System.EventHandler(this.searchTitleTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total quantity:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(453, 382);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(13, 13);
            this.totalLbl.TabIndex = 4;
            this.totalLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 409);
            this.Controls.Add(this.searchTitleTxt);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bookGrid);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.bookQuantityTxt);
            this.Controls.Add(this.bookPriceTxt);
            this.Controls.Add(this.bookTitleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookIdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookTitleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookPriceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookQuantityTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTitleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalLbl;
    }
}

