namespace BookClient
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
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // booksGrid
            // 
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Location = new System.Drawing.Point(13, 13);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.Size = new System.Drawing.Size(400, 222);
            this.booksGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BookID";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 241);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(68, 292);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBookID.TabIndex = 3;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(93, 241);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(174, 241);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(67, 319);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBookTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "BookPrice";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(67, 344);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBookPrice.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 433);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookPrice;
    }
}

