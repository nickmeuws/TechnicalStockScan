﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol;

namespace TechnicalStockScan
{
    public partial class ScanForm : ChildForm
    {
        // All the barcode scanner - related operations in this sample would be carried out  
        //  by using this reference of myScanSampleAPI which is an instance of the class 
        //  ScanSampleAPI. Will be initialized later in the code.
        private API myScanSampleAPI = null;
        private EventHandler myReadNotifyHandler = null;
        private EventHandler myStatusNotifyHandler = null;

        //private EventHandler myFormActivatedEventHandler = null;
        //private EventHandler myFormDeactivatedEventHandler = null;

        // The flag to track whether the reader has been initialized or not.
        private bool isReaderInitiated = false;

        //The last status information received from the scanner.
        private Symbol.Barcode.States prevState = Symbol.Barcode.States.ERROR;

        private StockServiceClient service = new StockServiceClient();

        public enum MODE { StockMovement = 1, StockCount = 2 }
        private MODE mode;

        public ScanForm(MainForm parent, MODE mode)
        {
            this.mode = mode;
            
            InitializeComponent();
            this.ParentForm = parent;

            setModeDependentLayout();

            // Initialize the ScanSampleAPI reference.
            this.myScanSampleAPI = new API();

            this.isReaderInitiated = this.myScanSampleAPI.InitReader();

            if (!(this.isReaderInitiated))// If the reader has not been initialized
            {
                // Display a message & exit the application.
                MessageBox.Show("Reader could not be initialized");
                Application.Exit();
            }
            else // If the reader has been initialized
            {

                // Attach a status natification handler.
                this.myStatusNotifyHandler = new EventHandler(myReader_StatusNotify);
                myScanSampleAPI.AttachStatusNotify(myStatusNotifyHandler);
            }         

            //Enable reading
            // Start a read operation & attach a handler.
            myScanSampleAPI.StartRead(false);
            this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
            myScanSampleAPI.AttachReadNotify(myReadNotifyHandler);
        }

        private void setModeDependentLayout()
        {
            lblTitle.Text = Resources.GetString(mode.ToString());

            switch (mode)
            {
                case MODE.StockMovement:
                    {
                        lblNewStock.Visible = false;
                        txtNewStock.Visible = false;
                        lblNewStockUOM.Visible = false;

                        lblCostPlace.Visible = true;
                        ddlCostPlace.Visible = true;
                        lblAmount.Visible = true;
                        txtAmount.Visible = true;
                        lblAmountUOM.Visible = true;

                        ddlCostPlace.DataSource = service.GetCostPlaces();
                        ddlCostPlace.ValueMember = "Id";
                        ddlCostPlace.DisplayMember = "Name";

                        break;
                    }
                case MODE.StockCount:
                    {
                        lblNewStock.Visible = true;
                        txtNewStock.Visible = true;
                        lblNewStockUOM.Visible = true;

                        lblCostPlace.Visible = false;
                        ddlCostPlace.Visible = false;
                        lblAmount.Visible = false;
                        txtAmount.Visible = false;
                        lblAmountUOM.Visible = false;

                        break;
                    }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            myScanSampleAPI.DetachReadNotify();
            myScanSampleAPI.DetachStatusNotify();
            myScanSampleAPI.TermReader();
            
            BackToParent();
        }

        /// <summary>
        /// Status notification handler.
        /// </summary>
        private void myReader_StatusNotify(object Sender, EventArgs e)
        {
            // Checks if the Invoke method is required because the StatusNotify delegate is called by a different thread
            if (this.InvokeRequired)
            {
                // Executes the StatusNotify delegate on the main thread
                this.Invoke(myStatusNotifyHandler, new object[] { Sender, e });
            }
            else
            {
                // Get ReaderData
                Symbol.Barcode.BarcodeStatus TheStatusData = this.myScanSampleAPI.Reader.GetNextStatus();

                switch (TheStatusData.State)
                {
                    case Symbol.Barcode.States.IDLE:
                        //if (currentListView == SCAN)
                        //    statusBar.Text = "Press trigger to scan";
                        break;

                    case Symbol.Barcode.States.READY:
                        //if ((currentListView == SCAN))
                        //    statusBar.Text = "Aim at barcode to scan";
                        break;

                    default:
                        //statusBar.Text = TheStatusData.Text;
                        break;
                }

                prevState = TheStatusData.State;
            }
        }

        /// <summary>
        /// Read notification handler.
        /// </summary>
        private void myReader_ReadNotify(object Sender, EventArgs e)
        {
            // Checks if the Invoke method is required because the ReadNotify delegate is called by a different thread
            if (this.InvokeRequired)
            {
                // Executes the ReadNotify delegate on the main thread
                this.Invoke(myReadNotifyHandler, new object[] { Sender, e });
            }
            else
            {
                // Get ReaderData
                Symbol.Barcode.ReaderData TheReaderData = this.myScanSampleAPI.Reader.GetNextReaderData();

                switch (TheReaderData.Result)
                {
                    case Symbol.Results.SUCCESS:

                        // Handle the data from this read & submit the next read.
                        HandleData(TheReaderData);
                        this.myScanSampleAPI.StartRead(false);

                        break;

                    case Symbol.Results.E_SCN_READTIMEOUT:
                            this.myScanSampleAPI.StartRead(false);
                        break;

                    case Symbol.Results.CANCELED:

                        break;

                    case Symbol.Results.E_SCN_DEVICEFAILURE:

                        this.myScanSampleAPI.StopRead();
                        this.myScanSampleAPI.StartRead(false);
                        break;

                    default:

                        string sMsg = "Read Failed\n"
                            + "Result = "
                            + (TheReaderData.Result).ToString();

                        if (TheReaderData.Result == Symbol.Results.E_SCN_READINCOMPATIBLE)
                        {
                            // If the failure is E_SCN_READINCOMPATIBLE, exit the application.

                            MessageBox.Show(Resources.GetString("AppExitMsg"), Resources.GetString("Failure"));

                            CloseScanForm();
                            return;
                        }

                        break;
                }
            }
        }

        private void CloseScanForm()
        {
            myScanSampleAPI.DetachReadNotify();
            myScanSampleAPI.DetachStatusNotify();
            myScanSampleAPI.TermReader();

            this.Close();
        }

        /// <summary>
        /// Handle data from the reader. Used in the scan mode.
        /// </summary>
        private void HandleData(Symbol.Barcode.ReaderData TheReaderData)
        {
            StockItem item = service.GetStockItem(TheReaderData.Text);

            if (item != null)
            {
                lblNo.Text = item.No_;
                lblDescription.Text = item.Description;
                lblCurrentStockUOM.Text = item.UOM;
                lblAmountUOM.Text = item.UOM;
                lblNewStockUOM.Text = item.UOM;
                lblCurrentStock.Text = (item.StockQuantity != null ? ((decimal)item.StockQuantity).ToString("0.####################"):"0");
            }
            else
            {
                lblNo.Text = TheReaderData.Text;
                lblDescription.Text = "Product code kon niet gevonden worden.";
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case MODE.StockMovement:
                    {
                        decimal currentStock = Convert.ToDecimal(lblCurrentStock.Text);
                        int costplaceId = Convert.ToInt32(ddlCostPlace.SelectedValue);
                        decimal quantity = Convert.ToDecimal(txtAmount.Text);
                        service.BookStockMovement(lblNo.Text, lblDescription.Text, currentStock, costplaceId, quantity, lblAmountUOM.Text, ParentForm.CurrentUser);

                        MessageBox.Show("Stockbeweging geboekt", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                        ClearAllValues();

                        break;
                    }
                case MODE.StockCount:
                    {
                        decimal currentStock = Convert.ToDecimal(lblCurrentStock.Text);
                        decimal newStock = Convert.ToDecimal(txtNewStock.Text);

                        if (newStock != currentStock)
                        {
                            var result = MessageBox.Show("Bent u zeker?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                service.BookStockCount(lblNo.Text, lblDescription.Text, currentStock, newStock, lblNewStockUOM.Text, ParentForm.CurrentUser);

                                MessageBox.Show("Stocktelling geboekt", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                                ClearAllValues();
                            }
                            else if (result == DialogResult.No)
                            {
                                MessageBox.Show("Stocktelling niet geboekt", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                            }
                        }
                        else
                        {
                            service.BookStockCount(lblNo.Text, lblDescription.Text, currentStock, newStock, lblNewStockUOM.Text, ParentForm.CurrentUser);

                            MessageBox.Show("Stocktelling geboekt", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                            ClearAllValues();
                        }

                        break;
                    }
            }
        }

        private void ClearAllValues()
        {
            lblNo.Text = string.Empty;
            lblDescription.Text = string.Empty;
            lblCurrentStock.Text = string.Empty;
            if(ddlCostPlace.Visible)
            {
                ddlCostPlace.SelectedIndex = 0;
            }
            txtAmount.Text = string.Empty;
            txtNewStock.Text = string.Empty;
        }
    }
}