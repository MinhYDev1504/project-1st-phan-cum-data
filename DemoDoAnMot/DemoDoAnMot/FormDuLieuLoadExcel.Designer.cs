namespace DemoDoAnMot
{
    partial class FormDuLieuLoadExcel
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.myOFD = new System.Windows.Forms.OpenFileDialog();
            this.dgvUsersProfile = new System.Windows.Forms.DataGridView();
            this.btnLoadToDgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(108, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(281, 20);
            this.txtFileName.TabIndex = 10;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 32);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbSheet
            // 
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(395, 19);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(111, 21);
            this.cbSheet.TabIndex = 11;
            // 
            // myOFD
            // 
            this.myOFD.FileName = "openFileDialog";
            this.myOFD.FileOk += new System.ComponentModel.CancelEventHandler(this.myOFD_FileOk);
            // 
            // dgvUsersProfile
            // 
            this.dgvUsersProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersProfile.Location = new System.Drawing.Point(12, 50);
            this.dgvUsersProfile.Name = "dgvUsersProfile";
            this.dgvUsersProfile.Size = new System.Drawing.Size(762, 304);
            this.dgvUsersProfile.TabIndex = 12;
            // 
            // btnLoadToDgv
            // 
            this.btnLoadToDgv.Location = new System.Drawing.Point(512, 12);
            this.btnLoadToDgv.Name = "btnLoadToDgv";
            this.btnLoadToDgv.Size = new System.Drawing.Size(176, 32);
            this.btnLoadToDgv.TabIndex = 13;
            this.btnLoadToDgv.Text = "Load Data Into DataGridView";
            this.btnLoadToDgv.UseVisualStyleBackColor = true;
            this.btnLoadToDgv.Click += new System.EventHandler(this.btnLoadToDgv_Click);
            // 
            // FormDuLieuLoadExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 366);
            this.Controls.Add(this.btnLoadToDgv);
            this.Controls.Add(this.dgvUsersProfile);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnOpen);
            this.Name = "FormDuLieuLoadExcel";
            this.Text = "Load Dữ Liệu From Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.OpenFileDialog myOFD;
        private System.Windows.Forms.DataGridView dgvUsersProfile;
        private System.Windows.Forms.Button btnLoadToDgv;
    }
}

