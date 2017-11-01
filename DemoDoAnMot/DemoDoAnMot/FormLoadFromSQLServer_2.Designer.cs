namespace DemoDoAnMot
{
    partial class FormLoadFromSQLServer_2
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUsersEnd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadBangMaHoa = new System.Windows.Forms.Button();
            this.btnMaHoaUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBangMa = new System.Windows.Forms.ComboBox();
            this.btnLoadUserBegin = new System.Windows.Forms.Button();
            this.dgvBangMaHoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsersBegin = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersEnd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangMaHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersBegin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvUsersEnd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 336);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ Liệu Users Facebook Sau Khi Được Mã Hóa Thành Giá Trị Nhị Phân 0 - 1";
            // 
            // dgvUsersEnd
            // 
            this.dgvUsersEnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersEnd.Location = new System.Drawing.Point(3, 20);
            this.dgvUsersEnd.Name = "dgvUsersEnd";
            this.dgvUsersEnd.Size = new System.Drawing.Size(867, 313);
            this.dgvUsersEnd.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadBangMaHoa);
            this.groupBox2.Controls.Add(this.btnMaHoaUsers);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbBangMa);
            this.groupBox2.Controls.Add(this.btnLoadUserBegin);
            this.groupBox2.Controls.Add(this.dgvBangMaHoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(884, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 628);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Mã Hóa Dữ Liệu";
            // 
            // btnLoadBangMaHoa
            // 
            this.btnLoadBangMaHoa.Location = new System.Drawing.Point(178, 440);
            this.btnLoadBangMaHoa.Name = "btnLoadBangMaHoa";
            this.btnLoadBangMaHoa.Size = new System.Drawing.Size(162, 48);
            this.btnLoadBangMaHoa.TabIndex = 21;
            this.btnLoadBangMaHoa.Text = "Load Bảng Mã";
            this.btnLoadBangMaHoa.UseVisualStyleBackColor = true;
            this.btnLoadBangMaHoa.Click += new System.EventHandler(this.btnLoadBangMaHoa_Click);
            // 
            // btnMaHoaUsers
            // 
            this.btnMaHoaUsers.Location = new System.Drawing.Point(57, 494);
            this.btnMaHoaUsers.Name = "btnMaHoaUsers";
            this.btnMaHoaUsers.Size = new System.Drawing.Size(239, 46);
            this.btnMaHoaUsers.TabIndex = 20;
            this.btnMaHoaUsers.Text = "Mã Hóa Dữ Liệu Cho Users";
            this.btnMaHoaUsers.UseVisualStyleBackColor = true;
            this.btnMaHoaUsers.Click += new System.EventHandler(this.btnMaHoaUsers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn Loại Dữ Liệu :";
            // 
            // cbBangMa
            // 
            this.cbBangMa.FormattingEnabled = true;
            this.cbBangMa.Location = new System.Drawing.Point(169, 406);
            this.cbBangMa.Name = "cbBangMa";
            this.cbBangMa.Size = new System.Drawing.Size(171, 26);
            this.cbBangMa.TabIndex = 18;
            // 
            // btnLoadUserBegin
            // 
            this.btnLoadUserBegin.Location = new System.Drawing.Point(9, 440);
            this.btnLoadUserBegin.Name = "btnLoadUserBegin";
            this.btnLoadUserBegin.Size = new System.Drawing.Size(163, 48);
            this.btnLoadUserBegin.TabIndex = 17;
            this.btnLoadUserBegin.Text = "Load Data Users";
            this.btnLoadUserBegin.UseVisualStyleBackColor = true;
            this.btnLoadUserBegin.Click += new System.EventHandler(this.btnLoadUserBegin_Click);
            // 
            // dgvBangMaHoa
            // 
            this.dgvBangMaHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangMaHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBangMaHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangMaHoa.Location = new System.Drawing.Point(6, 20);
            this.dgvBangMaHoa.Name = "dgvBangMaHoa";
            this.dgvBangMaHoa.Size = new System.Drawing.Size(334, 380);
            this.dgvBangMaHoa.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsersBegin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 289);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu Users Facebook";
            // 
            // dgvUsersBegin
            // 
            this.dgvUsersBegin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersBegin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersBegin.Location = new System.Drawing.Point(3, 20);
            this.dgvUsersBegin.Name = "dgvUsersBegin";
            this.dgvUsersBegin.Size = new System.Drawing.Size(864, 266);
            this.dgvUsersBegin.TabIndex = 13;
            // 
            // FormLoadFromSQLServer_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLoadFromSQLServer_2";
            this.Text = "FormLoadFromSQLServer_2";
            this.Load += new System.EventHandler(this.FormLoadFromSQLServer_2_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersEnd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangMaHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersBegin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvUsersEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadBangMaHoa;
        private System.Windows.Forms.Button btnMaHoaUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBangMa;
        private System.Windows.Forms.Button btnLoadUserBegin;
        private System.Windows.Forms.DataGridView dgvBangMaHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsersBegin;
    }
}