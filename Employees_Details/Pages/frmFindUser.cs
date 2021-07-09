using Service_API.Interface.Common;
using Service_API.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employees_Details.Pages
{
    public partial class frmFindUser : Form
    {
        private readonly IApiClient _api;
        public frmFindUser(IApiClient api)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                _api = api;
                InitializeComponent();

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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                DataListaUser listaUser = new DataListaUser();
                if (txtUserCode.Text != "")
                {
                    var dadosUser = _api.ExecutaGetNoParam<DataUser>($"users/{txtUserCode.Text}").Result;
                    listaUser.code = dadosUser.code;

                    dgvUsers.Rows.Clear();
                    var row = dgvUsers.Rows.Add();
                    dgvUsers.Rows[row].Cells["UserCode"].Value = dadosUser.data.id;
                    dgvUsers.Rows[row].Cells["UserName"].Value = dadosUser.data.name;
                    dgvUsers.Rows[row].Cells["Email"].Value = dadosUser.data.email;
                    dgvUsers.Rows[row].Cells["Status"].Value = dadosUser.data.status;
                    dgvUsers.Rows[row].Cells["Gender"].Value = dadosUser.data.gender;
                    dgvUsers.Rows[row].Cells["LastUpdate"].Value = dadosUser.data.updated_at;
                    dgvUsers.Rows[row].Cells["RegistrationDate"].Value = dadosUser.data.created_at;

                    lblPageInfo.Text = $"Page 0 to 0";
                    txtPage.Text = "";
                    txtCurrentPage.Text = "";
                    txtLastPage.Text = "";
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnGo.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;

                    return;
                }
                else if (txtUserName.Text != "")
                {
                    listaUser = _api.ExecutaGetNoParam<DataListaUser>($"users?first_name={txtUserName.Text}").Result;
                }
                else
                {
                    listaUser = _api.ExecutaGetNoParam<DataListaUser>($"users").Result;
                }

                LoadGrid(listaUser);
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

        private void bntReload_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnGo.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                LoadGrid(_api.ExecutaGetNoParam<DataListaUser>("users").Result);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int newPage = Convert.ToInt32(txtCurrentPage.Text);
                newPage++;
                if (newPage < Convert.ToInt32(txtLastPage.Text))
                {
                    LoadGrid(_api.ExecutaGetNoParam<DataListaUser>($"users?page={newPage}").Result);
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                }
                if (newPage == Convert.ToInt32(txtLastPage.Text))
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txtCurrentPage.Text != txtLastPage.Text)
                {
                    LoadGrid(_api.ExecutaGetNoParam<DataListaUser>($"users?page={txtLastPage.Text}").Result);
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int CurrentPage = Convert.ToInt32(txtCurrentPage.Text);
            int LastPage = Convert.ToInt32(txtLastPage.Text);
            int newPage = Convert.ToInt32(txtPage.Text);

            if (newPage != CurrentPage && newPage <= LastPage && newPage > 0)
            {
                LoadGrid(_api.ExecutaGetNoParam<DataListaUser>($"users?page={newPage}").Result);
                if (newPage == 1)
                {
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                }
                else if (newPage == LastPage)
                {
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid page entered. please enter a valid page;", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                int newPage = Convert.ToInt32(txtCurrentPage.Text);
                newPage--;
                if (newPage > 0)
                {
                    LoadGrid(_api.ExecutaGetNoParam<DataListaUser>($"users?page={newPage}").Result);
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;

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

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txtPage.Text != "1")
                {
                    LoadGrid(_api.ExecutaGetNoParam<DataListaUser>($"users?page=1").Result);

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
        private void LoadGrid(DataListaUser md)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (md != null)
                {
                    lblPageInfo.Text = $"Page {md.meta.pagination.page} to {md.meta.pagination.pages}";
                    txtPage.Text = md.meta.pagination.page.ToString();
                    txtCurrentPage.Text = md.meta.pagination.page.ToString();
                    txtLastPage.Text = md.meta.pagination.pages.ToString();
                    dgvUsers.Rows.Clear();
                    foreach (var linha in md.data)
                    {
                        var row = dgvUsers.Rows.Add();
                        dgvUsers.Rows[row].Cells["UserCode"].Value = linha.id;
                        dgvUsers.Rows[row].Cells["UserName"].Value = linha.name;
                        dgvUsers.Rows[row].Cells["Email"].Value = linha.email;
                        dgvUsers.Rows[row].Cells["Status"].Value = linha.status;
                        dgvUsers.Rows[row].Cells["Gender"].Value = linha.gender;
                        dgvUsers.Rows[row].Cells["LastUpdate"].Value = linha.updated_at;
                        dgvUsers.Rows[row].Cells["RegistrationDate"].Value = linha.created_at;
                    }

                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnGo.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;

                    if (txtCurrentPage.Text == "1")
                    {
                        btnFirst.Enabled = false;
                        btnPrevious.Enabled = false;
                    }
                    if (txtCurrentPage.Text == txtLastPage.Text)
                    {
                        btnLast.Enabled = false;
                        btnNext.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("No Users Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["btnShow"].Index)
            {
                this.Cursor = Cursors.WaitCursor;
                var usercode = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UserCode"].Value);
                frmDadosUsu dadosUsu = new frmDadosUsu(_api, usercode);
                dadosUsu.MdiParent = this.MdiParent;
                dadosUsu.Show();

                this.Cursor = Cursors.Default;
            }
        }

        private void bntExportCSV_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the csv
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "File|*.CSV";
            saveFileDialog.Title = "Save as File";
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                StreamWriter FileCSV = new StreamWriter(saveFileDialog.FileName, true);
                string info = "";
                info = "Code;User Name;Email;Status;Gender;Last Update;Registration Date;" + Environment.NewLine;

                try
                {
                    foreach (DataGridViewRow row in dgvUsers.Rows)
                    {
                        info += row.Cells["UserCode"].Value + ";";
                        info += row.Cells["UserName"].Value + ";";
                        info += row.Cells["Email"].Value + ";";
                        info += row.Cells["Status"].Value + ";";
                        info += row.Cells["Gender"].Value + ";";
                        info += row.Cells["LastUpdate"].Value + ";";
                        info += row.Cells["RegistrationDate"].Value + ";";
                        info += Environment.NewLine;
                    }

                    FileCSV.Write(info);

                    FileCSV.Close();
                    FileCSV.Dispose();
                    FileCSV = null;

                    MessageBox.Show("Lista exportada com sucesso", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("A failure occurred during the export process. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    FileCSV.Close();
                    FileCSV.Dispose();

                    if (File.Exists(saveFileDialog.FileName))
                    {
                        File.Delete(saveFileDialog.FileName);
                    }
                }

            }
        }

        private void frmFindUser_Enter(object sender, EventArgs e)
        {
            if(txtCurrentPage.Text== "")
            {
                LoadGrid(_api.ExecutaGetNoParam<DataListaUser>("users").Result);
            }
            else
            {
                LoadGrid(_api.ExecutaGetNoParam<DataListaUser>($"users?page={txtCurrentPage.Text}").Result);
            }
        }
    }
}
