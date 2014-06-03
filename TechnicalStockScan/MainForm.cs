using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TechnicalStockScan
{
    public partial class MainForm : FullScreenForm
    {
        public string CurrentUser { get; set; }

        public StockServiceClient Service { get; private set; }

        private LoginForm loginForm;

        public MainForm()
        {
            InitializeComponent();

            Service = new StockServiceClient();

            loginForm = new LoginForm(this);
            loginForm.ShowDialog();
        }

        private void btnStockMovement_Click(object sender, EventArgs e)
        {
            var newForm = new ScanForm(this, ScanForm.MODE.StockMovement);
            newForm.ShowDialog();
        }

        private void btnStockCount_Click(object sender, EventArgs e)
        {
            var newForm = new ScanForm(this, ScanForm.MODE.StockCount);
            newForm.ShowDialog();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            SetHHTaskBar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}