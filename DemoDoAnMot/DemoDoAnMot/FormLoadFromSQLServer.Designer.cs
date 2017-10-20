namespace DemoDoAnMot
{
    partial class FormLoadFromSQLServer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsersBegin = new System.Windows.Forms.DataGridView();
            this.dgvBangMaHoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadBangMaHoa = new System.Windows.Forms.Button();
            this.btnMaHoaUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBangMa = new System.Windows.Forms.ComboBox();
            this.btnLoadUserBegin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvUsersEnd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangMaHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersBegin
            // 
            this.dgvUsersBegin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersBegin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersBegin.Location = new System.Drawing.Point(3, 20);
            this.dgvUsersBegin.Name = "dgvUsersBegin";
            this.dgvUsersBegin.Size = new System.Drawing.Size(574, 187);
            this.dgvUsersBegin.TabIndex = 13;
            // 
            // dgvBangMaHoa
            // 
            this.dgvBangMaHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangMaHoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBangMaHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangMaHoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangMaHoa.Location = new System.Drawing.Point(6, 20);
            this.dgvBangMaHoa.Name = "dgvBangMaHoa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangMaHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangMaHoa.Size = new System.Drawing.Size(334, 252);
            this.dgvBangMaHoa.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsersBegin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 210);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu Users Facebook";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(599, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 423);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Mã Hóa Dữ Liệu";
            // 
            // btnLoadBangMaHoa
            // 
            this.btnLoadBangMaHoa.Location = new System.Drawing.Point(178, 317);
            this.btnLoadBangMaHoa.Name = "btnLoadBangMaHoa";
            this.btnLoadBangMaHoa.Size = new System.Drawing.Size(162, 48);
            this.btnLoadBangMaHoa.TabIndex = 21;
            this.btnLoadBangMaHoa.Text = "Load Bảng Mã";
            this.btnLoadBangMaHoa.UseVisualStyleBackColor = true;
            this.btnLoadBangMaHoa.Click += new System.EventHandler(this.btnLoadBangMaHoa_Click);
            // 
            // btnMaHoaUsers
            // 
            this.btnMaHoaUsers.Location = new System.Drawing.Point(57, 371);
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
            this.label1.Location = new System.Drawing.Point(6, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chọn Loại Dữ Liệu :";
            // 
            // cbBangMa
            // 
            this.cbBangMa.FormattingEnabled = true;
            this.cbBangMa.Location = new System.Drawing.Point(169, 283);
            this.cbBangMa.Name = "cbBangMa";
            this.cbBangMa.Size = new System.Drawing.Size(171, 26);
            this.cbBangMa.TabIndex = 18;
            // 
            // btnLoadUserBegin
            // 
            this.btnLoadUserBegin.Location = new System.Drawing.Point(9, 317);
            this.btnLoadUserBegin.Name = "btnLoadUserBegin";
            this.btnLoadUserBegin.Size = new System.Drawing.Size(163, 48);
            this.btnLoadUserBegin.TabIndex = 17;
            this.btnLoadUserBegin.Text = "Load Data Users";
            this.btnLoadUserBegin.UseVisualStyleBackColor = true;
            this.btnLoadUserBegin.Click += new System.EventHandler(this.btnLoadUserBegin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvUsersEnd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 210);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ Liệu Users Facebook Sau Khi Được Mã Hóa";
            // 
            // dgvUsersEnd
            // 
            this.dgvUsersEnd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersEnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersEnd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersEnd.Location = new System.Drawing.Point(3, 20);
            this.dgvUsersEnd.Name = "dgvUsersEnd";
            this.dgvUsersEnd.Size = new System.Drawing.Size(574, 187);
            this.dgvUsersEnd.TabIndex = 13;
            // 
            // FormLoadFromSQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLoadFromSQLServer";
            this.Text = "Load Và Mã Hóa Dữ Liệu From SQL Server";
            this.Load += new System.EventHandler(this.FormLoadFromSQLServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangMaHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersEnd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsersBegin;
        private System.Windows.Forms.DataGridView dgvBangMaHoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvUsersEnd;
        private System.Windows.Forms.Button btnLoadBangMaHoa;
        private System.Windows.Forms.Button btnMaHoaUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBangMa;
        private System.Windows.Forms.Button btnLoadUserBegin;
    }
}