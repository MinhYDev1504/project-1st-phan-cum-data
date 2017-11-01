﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDoAnMot
{
    public partial class FormLoadFromSQLServer : Form
    {
        //--Variables
        string strConnectionString =
            "Data Source = (local);" +
            "Initial Catalog = FacebookUsers;" +
            "Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter daTemp = null;
        DataTable dtTemp = null;
        public FormLoadFromSQLServer()
        {
            InitializeComponent();
        }

        private void btnLoadUserBegin_Click(object sender, EventArgs e)
        {
            LoadDataUserBegin();
        }

        private void LoadDataUserBegin()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daTemp = new SqlDataAdapter(
                    "SELECT * FROM Users", conn);
                dtTemp = new DataTable();
                dtTemp.Clear();
                daTemp.Fill(dtTemp);
                dgvUsersBegin.DataSource = dtTemp;
                dgvUsersBegin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không Lấy Được Nội Dung Từ SQLServer\n" +
                    "ErrorInformation: " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadBangMaHoa_Click(object sender, EventArgs e)
        {
            LoadBangMa();
        }

        private void LoadBangMa()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daTemp = new SqlDataAdapter(
                    "SELECT * FROM " + cbBangMa.SelectedItem.ToString(), conn);
                dtTemp = new DataTable();
                dtTemp.Clear();
                daTemp.Fill(dtTemp);
                dgvBangMaHoa.DataSource = dtTemp;
                dgvBangMaHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không Lấy Được Nội Dung Từ SQLServer\n" +
                    "ErrorInformation: " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMaHoaUsers_Click(object sender, EventArgs e)
        {
            LoadDataUsersEnd();
        }

        private void LoadDataUsersEnd()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daTemp = new SqlDataAdapter(
                    "EXEC dbo.uspGetEncryptedUser", conn);
                dtTemp = new DataTable();
                dtTemp.Clear();
                daTemp.Fill(dtTemp);
                dgvUsersEnd.DataSource = dtTemp;
                dgvUsersEnd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không Lấy Được Nội Dung Từ SQLServer\n" +
                      "ErrorInformation: " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLoadFromSQLServer_Load(object sender, EventArgs e)
        {
            //comboBox Chọn Loại Dữ Liệu
            cbBangMa.Items.Add("GioiTinh");
            cbBangMa.Items.Add("ThanhPho");
            cbBangMa.Items.Add("SinhNhat");
            cbBangMa.Items.Add("TrangThaiTinhCam");
            cbBangMa.SelectedItem = "GioiTinh";
        }
    }
}
