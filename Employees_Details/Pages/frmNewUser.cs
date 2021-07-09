using Service_API.Interface.Common;
using Service_API.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Employees_Details.Pages
{
    public partial class frmNewUser : Form
    {
        private readonly IApiClient _api;
        public frmNewUser(IApiClient api)
        {
            _api = api;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (Validate())
                {
                    if (MessageBox.Show("Do you confirm the inclusion of this new user?", "Caution",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                    {
                        UserModel user = new UserModel();
                        user.gender = cboGender.SelectedItem.ToString();
                        user.email = txtEmail.Text;
                        user.name = txtUserName.Text;
                        user.status = "Active";
                        user.updated_at = DateTime.Now;
                        user.created_at = DateTime.Now;

                        _api.ExecutaPostNoResult<UserModel>($"users", user);

                        MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private bool Validate()
        {
            bool valid = true;
            if (txtUserName.Text == "")
            {
                MessageBox.Show("It is mandatory to inform the username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("It is mandatory to inform the Email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }
            else if (cboGender.SelectedItem.ToString() == "")
            {
                MessageBox.Show("It is mandatory to inform the gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }

            return valid;
        }
    }
}
