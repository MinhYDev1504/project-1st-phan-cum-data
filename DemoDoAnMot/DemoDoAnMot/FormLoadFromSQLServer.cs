using System;
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
        SqlDataAdapter daUserBegin = null;
        DataTable dtUserBegin = null;
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
                daUserBegin = new SqlDataAdapter(
                    "SELECT * FROM Users", conn);
                dtUserBegin = new DataTable();
                dtUserBegin.Clear();
                daUserBegin.Fill(dtUserBegin);
                dgvUsersBegin.DataSource = dtUserBegin;
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
                daUserBegin = new SqlDataAdapter(
                    "SELECT * FROM " + cbBangMa.SelectedItem.ToString(), conn);
                dtUserBegin = new DataTable();
                dtUserBegin.Clear();
                daUserBegin.Fill(dtUserBegin);
                dgvBangMaHoa.DataSource = dtUserBegin;
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
                daUserBegin = new SqlDataAdapter(
                    "EXEC dbo.uspGetEncryptedUser", conn);
                dtUserBegin = new DataTable();
                dtUserBegin.Clear();
                daUserBegin.Fill(dtUserBegin);
                dgvUsersEnd.DataSource = dtUserBegin;
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
