using Employees_Details.Pages;
using Service_API.Interface.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employees_Details
{
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        private readonly IApiClient _api;
        public MDIMain(IApiClient api)
        {
            _api = api;
            InitializeComponent();

            frmFindUser searchUser = new frmFindUser(_api);
            searchUser.MdiParent = this;
            searchUser.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           var itemMenu = e.ClickedItem.Text;

            switch (itemMenu)
            {
                case "Search User":
                    frmFindUser searchUser = new frmFindUser(_api);
                    searchUser.MdiParent = this;
                    searchUser.Show();
                    break;
                case "New User":
                    frmNewUser newUser = new frmNewUser(_api);
                    newUser.MdiParent = this;
                    newUser.Show();
                    break;

            }
        }
    }
}
