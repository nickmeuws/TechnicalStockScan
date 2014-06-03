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
    public partial class LoginForm : ChildForm
    {
        public LoginForm(MainForm parent)
        {
            this.ParentForm = parent;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ParentForm.Service.AuthenticateUser(txtUserName.Text.Trim(), txtPassword.Text))
            {
                ParentForm.CurrentUser = txtUserName.Text.Trim();
                BackToParent();
            }
            else
            {
                lblError.Text = "Foutieve Gebruikersnaam/Paswoord";
                lblError.Visible = true;
            }
        }
    }
}