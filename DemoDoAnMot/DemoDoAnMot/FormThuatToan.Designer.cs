namespace DemoDoAnMot
{
    partial class frmThuatToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKValue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCenters = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowOriginalData = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartAlgorithm = new System.Windows.Forms.Button();
            this.txtSelectedCluster = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenters)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Cụm Dữ Liệu Với Thuật Toán K-means Dùng Khoảng Cách Euclide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn K :";
            // 
            // cbKValue
            // 
            this.cbKValue.FormattingEnabled = true;
            this.cbKValue.Location = new System.Drawing.Point(105, 90);
            this.cbKValue.Name = "cbKValue";
            this.cbKValue.Size = new System.Drawing.Size(121, 21);
            this.cbKValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trung tâm của mỗi nhóm (Click để chọn)";
            // 
            // dgvCenters
            // 
            this.dgvCenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCenters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCenters.Location = new System.Drawing.Point(16, 165);
            this.dgvCenters.Name = "dgvCenters";
            this.dgvCenters.Size = new System.Drawing.Size(500, 173);
            this.dgvCenters.TabIndex = 4;
            this.dgvCenters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCenters_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowOriginalData);
            this.groupBox1.Controls.Add(this.dgvUsers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(522, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 463);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các dữ liệu thuộc nhóm có trung tâm tương ứng";
            // 
            // btnShowOriginalData
            // 
            this.btnShowOriginalData.Location = new System.Drawing.Point(7, 400);
            this.btnShowOriginalData.Name = "btnShowOriginalData";
            this.btnShowOriginalData.Size = new System.Drawing.Size(277, 57);
            this.btnShowOriginalData.TabIndex = 1;
            this.btnShowOriginalData.Text = "Xem Dữ Liệu Được Mã Hóa Khi Dùng Khoảng Cách Euclide";
            this.btnShowOriginalData.UseVisualStyleBackColor = true;
            this.btnShowOriginalData.Click += new System.EventHandler(this.btnShowOriginalData_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(6, 23);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvUsers.Size = new System.Drawing.Size(778, 370);
            this.dgvUsers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khoảng cách Euclide hiện tại :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 26);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 58);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giá trị bình phương sai :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 26);
            this.textBox2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bạn đang chọn nhóm :";
            // 
            // btnStartAlgorithm
            // 
            this.btnStartAlgorithm.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnStartAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartAlgorithm.ForeColor = System.Drawing.Color.Red;
            this.btnStartAlgorithm.Location = new System.Drawing.Point(249, 76);
            this.btnStartAlgorithm.Name = "btnStartAlgorithm";
            this.btnStartAlgorithm.Size = new System.Drawing.Size(217, 61);
            this.btnStartAlgorithm.TabIndex = 10;
            this.btnStartAlgorithm.Text = "Bắt Đầu Phân Cụm";
            this.btnStartAlgorithm.UseVisualStyleBackColor = false;
            this.btnStartAlgorithm.Click += new System.EventHandler(this.btnStartAlgorithm_Click);
            // 
            // txtSelectedCluster
            // 
            this.txtSelectedCluster.Enabled = false;
            this.txtSelectedCluster.Location = new System.Drawing.Point(228, 376);
            this.txtSelectedCluster.Name = "txtSelectedCluster";
            this.txtSelectedCluster.Size = new System.Drawing.Size(100, 20);
            this.txtSelectedCluster.TabIndex = 11;
            this.txtSelectedCluster.Text = "Nhóm 1";
            // 
            // frmThuatToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 536);
            this.Controls.Add(this.txtSelectedCluster);
            this.Controls.Add(this.btnStartAlgorithm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCenters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThuatToan";
            this.Text = "FormThuatToan";
            this.Load += new System.EventHandler(this.frmThuatToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenters)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCenters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartAlgorithm;
        private System.Windows.Forms.TextBox txtSelectedCluster;
        private System.Windows.Forms.Button btnShowOriginalData;
    }
}