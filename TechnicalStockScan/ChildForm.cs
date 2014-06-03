using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TechnicalStockScan
{
    public partial class ChildForm : FullScreenForm
    {
        public MainForm ParentForm { get; set; }
        
        public ChildForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        protected void BackToParent(){
            ParentForm.Show();
            this.Close();
        }
    }
}