namespace TechnicalStockScan
{
    partial class ScanForm
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
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCostPlace = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNewStock = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblCurrentStockUOM = new System.Windows.Forms.Label();
            this.lblAmountUOM = new System.Windows.Forms.Label();
            this.ddlCostPlace = new System.Windows.Forms.ComboBox();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.lblNewStockUOM = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnBook.Location = new System.Drawing.Point(20, 228);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(97, 45);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Boeken";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnBack.Location = new System.Drawing.Point(129, 228);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Terug";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.Text = "No.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.Text = "Omschr.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.Text = "Huidige voorraad";
            // 
            // lblCostPlace
            // 
            this.lblCostPlace.Location = new System.Drawing.Point(3, 152);
            this.lblCostPlace.Name = "lblCostPlace";
            this.lblCostPlace.Size = new System.Drawing.Size(64, 34);
            this.lblCostPlace.Text = "Kosten-plaats";
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(3, 187);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 40);
            this.lblAmount.Text = "Aantal stuks";
            // 
            // lblNewStock
            // 
            this.lblNewStock.Location = new System.Drawing.Point(3, 159);
            this.lblNewStock.Name = "lblNewStock";
            this.lblNewStock.Size = new System.Drawing.Size(64, 34);
            this.lblNewStock.Text = "Niewe voorraad";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 30);
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.Location = new System.Drawing.Point(64, 115);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(119, 20);
            this.lblCurrentStock.Text = "label7";
            // 
            // lblCurrentStockUOM
            // 
            this.lblCurrentStockUOM.Location = new System.Drawing.Point(188, 115);
            this.lblCurrentStockUOM.Name = "lblCurrentStockUOM";
            this.lblCurrentStockUOM.Size = new System.Drawing.Size(45, 20);
            this.lblCurrentStockUOM.Text = "label8";
            // 
            // lblAmountUOM
            // 
            this.lblAmountUOM.Location = new System.Drawing.Point(188, 197);
            this.lblAmountUOM.Name = "lblAmountUOM";
            this.lblAmountUOM.Size = new System.Drawing.Size(45, 20);
            this.lblAmountUOM.Text = "label9";
            // 
            // ddlCostPlace
            // 
            this.ddlCostPlace.Location = new System.Drawing.Point(64, 158);
            this.ddlCostPlace.Name = "ddlCostPlace";
            this.ddlCostPlace.Size = new System.Drawing.Size(169, 23);
            this.ddlCostPlace.TabIndex = 17;
            // 
            // txtNewStock
            // 
            this.txtNewStock.Location = new System.Drawing.Point(64, 165);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(119, 23);
            this.txtNewStock.TabIndex = 18;
            // 
            // lblNewStockUOM
            // 
            this.lblNewStockUOM.Location = new System.Drawing.Point(188, 166);
            this.lblNewStockUOM.Name = "lblNewStockUOM";
            this.lblNewStockUOM.Size = new System.Drawing.Size(45, 20);
            this.lblNewStockUOM.Text = "label10";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(64, 196);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(119, 23);
            this.txtAmount.TabIndex = 21;
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(64, 38);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(161, 20);
            this.lblNo.Text = "label4";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(64, 58);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(161, 58);
            this.lblDescription.Text = "label5";
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblNewStockUOM);
            this.Controls.Add(this.txtNewStock);
            this.Controls.Add(this.ddlCostPlace);
            this.Controls.Add(this.lblAmountUOM);
            this.Controls.Add(this.lblCurrentStockUOM);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNewStock);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCostPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBook);
            this.Name = "ScanForm";
            this.Text = "Technical Stock Scan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCostPlace;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNewStock;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblCurrentStockUOM;
        private System.Windows.Forms.Label lblAmountUOM;
        private System.Windows.Forms.ComboBox ddlCostPlace;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.Label lblNewStockUOM;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblDescription;
    }
}