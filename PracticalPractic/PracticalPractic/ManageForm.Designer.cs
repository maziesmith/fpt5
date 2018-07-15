namespace PracticalPractic
{
    partial class ManageForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bookGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterTxt = new System.Windows.Forms.TextBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.bookQuantityTxt = new System.Windows.Forms.TextBox();
            this.bookPriceTxt = new System.Windows.Forms.TextBox();
            this.bookTitleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookIdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bookGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bookGrid
            // 
            this.bookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookGrid.Location = new System.Drawing.Point(3, 103);
            this.bookGrid.Name = "bookGrid";
            this.bookGrid.Size = new System.Drawing.Size(489, 205);
            this.bookGrid.TabIndex = 0;
            this.bookGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterTxt);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.bookQuantityTxt);
            this.panel1.Controls.Add(this.bookPriceTxt);
            this.panel1.Controls.Add(this.bookTitleTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bookIdTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 94);
            this.panel1.TabIndex = 1;
            // 
            // filterTxt
            // 
            this.filterTxt.Location = new System.Drawing.Point(370, 62);
            this.filterTxt.Name = "filterTxt";
            this.filterTxt.Size = new System.Drawing.Size(100, 20);
            this.filterTxt.TabIndex = 3;
            this.filterTxt.TextChanged += new System.EventHandler(this.filterTxt_TextChanged);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(269, 60);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(107, 60);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(188, 60);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(26, 60);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // bookQuantityTxt
            // 
            this.bookQuantityTxt.Location = new System.Drawing.Point(312, 30);
            this.bookQuantityTxt.Name = "bookQuantityTxt";
            this.bookQuantityTxt.Size = new System.Drawing.Size(159, 20);
            this.bookQuantityTxt.TabIndex = 1;
            // 
            // bookPriceTxt
            // 
            this.bookPriceTxt.Location = new System.Drawing.Point(312, 7);
            this.bookPriceTxt.Name = "bookPriceTxt";
            this.bookPriceTxt.Size = new System.Drawing.Size(159, 20);
            this.bookPriceTxt.TabIndex = 1;
            // 
            // bookTitleTxt
            // 
            this.bookTitleTxt.Location = new System.Drawing.Point(71, 30);
            this.bookTitleTxt.Name = "bookTitleTxt";
            this.bookTitleTxt.Size = new System.Drawing.Size(159, 20);
            this.bookTitleTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // bookIdTxt
            // 
            this.bookIdTxt.Location = new System.Drawing.Point(71, 7);
            this.bookIdTxt.Name = "bookIdTxt";
            this.bookIdTxt.Size = new System.Drawing.Size(159, 20);
            this.bookIdTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageForm";
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView bookGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox bookTitleTxt;
        private System.Windows.Forms.TextBox bookIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox bookQuantityTxt;
        private System.Windows.Forms.TextBox bookPriceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filterTxt;
    }
}