using System.Windows.Forms;
using System;
namespace TechnicalStockScan
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStockMovement = new System.Windows.Forms.Button();
            this.btnStockCount = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 20);
            this.lblTitle.Text = "Scanning Technisch Magazijn";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnStockMovement
            // 
            this.btnStockMovement.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnStockMovement.Location = new System.Drawing.Point(29, 43);
            this.btnStockMovement.Name = "btnStockMovement";
            this.btnStockMovement.Size = new System.Drawing.Size(180, 80);
            this.btnStockMovement.TabIndex = 1;
            this.btnStockMovement.Text = "Stockbeweging";
            this.btnStockMovement.Click += new System.EventHandler(this.btnStockMovement_Click);
            // 
            // btnStockCount
            // 
            this.btnStockCount.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnStockCount.Location = new System.Drawing.Point(29, 139);
            this.btnStockCount.Name = "btnStockCount";
            this.btnStockCount.Size = new System.Drawing.Size(180, 80);
            this.btnStockCount.TabIndex = 2;
            this.btnStockCount.Text = "Stocktelling";
            this.btnStockCount.Click += new System.EventHandler(this.btnStockCount_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.btnClose.Location = new System.Drawing.Point(29, 235);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Afsluiten";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStockCount);
            this.Controls.Add(this.btnStockMovement);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Technical Stock Scan";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStockMovement;
        private System.Windows.Forms.Button btnStockCount;
        private System.Windows.Forms.Button btnClose;

    }
}

