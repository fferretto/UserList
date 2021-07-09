
namespace Employees_Details.Pages
{
    partial class frmFindUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntExportCSV = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserCode = new System.Windows.Forms.TextBox();
            this.bntReload = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtLastPage = new System.Windows.Forms.TextBox();
            this.txtCurrentPage = new System.Windows.Forms.TextBox();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter and search users";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bntExportCSV);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtUserCode);
            this.panel2.Controls.Add(this.bntReload);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 100);
            this.panel2.TabIndex = 1;
            // 
            // bntExportCSV
            // 
            this.bntExportCSV.Location = new System.Drawing.Point(618, 67);
            this.bntExportCSV.Name = "bntExportCSV";
            this.bntExportCSV.Size = new System.Drawing.Size(114, 23);
            this.bntExportCSV.TabIndex = 8;
            this.bntExportCSV.Text = "Export to CSV";
            this.bntExportCSV.UseVisualStyleBackColor = true;
            this.bntExportCSV.Click += new System.EventHandler(this.bntExportCSV_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 68);
            this.txtUserName.MaxLength = 60;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(518, 23);
            this.txtUserName.TabIndex = 7;
            // 
            // txtUserCode
            // 
            this.txtUserCode.Location = new System.Drawing.Point(12, 23);
            this.txtUserCode.MaxLength = 5;
            this.txtUserCode.Name = "txtUserCode";
            this.txtUserCode.Size = new System.Drawing.Size(110, 23);
            this.txtUserCode.TabIndex = 6;
            // 
            // bntReload
            // 
            this.bntReload.Location = new System.Drawing.Point(819, 67);
            this.bntReload.Name = "bntReload";
            this.bntReload.Size = new System.Drawing.Size(75, 23);
            this.bntReload.TabIndex = 4;
            this.bntReload.Text = "Reload";
            this.bntReload.UseVisualStyleBackColor = true;
            this.bntReload.Click += new System.EventHandler(this.bntReload_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(738, 67);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Code";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnShow,
            this.UserCode,
            this.UserName,
            this.Email,
            this.Status,
            this.Gender,
            this.LastUpdate,
            this.RegistrationDate});
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(1, 138);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(904, 429);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // btnShow
            // 
            this.btnShow.HeaderText = "        ";
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.Name = "btnShow";
            this.btnShow.ReadOnly = true;
            this.btnShow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnShow.Width = 40;
            // 
            // UserCode
            // 
            this.UserCode.HeaderText = "Code";
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            this.UserCode.Width = 60;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 300;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 300;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // LastUpdate
            // 
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.ReadOnly = true;
            this.LastUpdate.Visible = false;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.HeaderText = "RegistrationDate";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            this.RegistrationDate.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtPage);
            this.panel3.Controls.Add(this.txtLastPage);
            this.panel3.Controls.Add(this.txtCurrentPage);
            this.panel3.Controls.Add(this.lblPageInfo);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Controls.Add(this.btnGo);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Location = new System.Drawing.Point(1, 568);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 47);
            this.panel3.TabIndex = 3;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(673, 14);
            this.txtPage.MaxLength = 5;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 23);
            this.txtPage.TabIndex = 8;
            // 
            // txtLastPage
            // 
            this.txtLastPage.Location = new System.Drawing.Point(290, 14);
            this.txtLastPage.Name = "txtLastPage";
            this.txtLastPage.Size = new System.Drawing.Size(100, 23);
            this.txtLastPage.TabIndex = 7;
            this.txtLastPage.Visible = false;
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.Location = new System.Drawing.Point(133, 14);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.Size = new System.Drawing.Size(100, 23);
            this.txtCurrentPage.TabIndex = 6;
            this.txtCurrentPage.Visible = false;
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(13, 22);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(65, 15);
            this.lblPageInfo.TabIndex = 5;
            this.lblPageInfo.Text = "Page 0 to 0";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(811, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(853, 13);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(44, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(775, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(34, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(611, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(61, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(566, 13);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(44, 23);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // frmFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 616);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFindUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of registered users";
            this.Enter += new System.EventHandler(this.frmFindUser_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserCode;
        private System.Windows.Forms.Button bntReload;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtLastPage;
        private System.Windows.Forms.TextBox txtCurrentPage;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.DataGridViewImageColumn btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button bntExportCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
    }
}