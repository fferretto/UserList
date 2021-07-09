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
    public partial class frmDadosUsu : Form
    {
        private readonly IApiClient _api;
        public frmDadosUsu(IApiClient api, int userCode)
        {
            try
            {
                _api = api;
                InitializeComponent();
                LoadComboBox();
                var dadosUsu = _api.ExecutaGetNoParam<DataUser>($"users/{userCode}").Result;
                txtUserCode.Text = dadosUsu.data.id.ToString();
                txtUserName.Text = dadosUsu.data.name;
                txtEmail.Text = dadosUsu.data.email;
                cboGender.SelectedItem = dadosUsu.data.gender;
                cboStatus.SelectedItem = dadosUsu.data.status;
                txtLastUpdate.Text = dadosUsu.data.updated_at.ToShortDateString();
                txtRegistrationDate.Text = dadosUsu.data.created_at.ToShortDateString();

                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void LoadComboBox()
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            cboStatus.Items.Add("Active");
            cboStatus.Items.Add("Inactive");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel user = new UserModel();
                user.gender = cboGender.SelectedItem.ToString();
                user.email = txtEmail.Text;
                user.name = txtUserName.Text;
                user.status = cboStatus.SelectedItem.ToString();
                user.updated_at = DateTime.Now;

                _api.ExecutaPutNoResult<UserModel>($"users", user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (MessageBox.Show("Do you confirm the removal from the system user?", "Caution",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    _api.ExecutaDeleteNoResult($"users/{txtUserCode.Text}");

                    MessageBox.Show("User removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                UserModel user = new UserModel();
                user.gender = cboGender.SelectedItem.ToString();
                user.email = txtEmail.Text;
                user.name = txtUserName.Text;
                user.status = cboStatus.SelectedItem.ToString();
                user.updated_at = DateTime.Now;
                user.created_at = Convert.ToDateTime(txtRegistrationDate.Text);

                _api.ExecutaPutNoResult<UserModel>($"users/{txtUserCode.Text}", user);

                MessageBox.Show("User changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
