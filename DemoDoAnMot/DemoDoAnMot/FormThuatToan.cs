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
    public partial class frmThuatToan : Form
    {
        //Khai Báo Biến
        string strConnectionString ="Data Source=localhost;" +
            "Initial Catalog = FacebookUsers;" +
            "User ID =sa;Password=123456";//-- or Integrated Security = True
        SqlConnection conn = null;
        SqlDataAdapter daUsers = null;
        DataTable dtUsers = null;
        /*-------------------------*/
        List<EncryptedUser> listEUs;    //--> List EncryptedUsers Của Thuật Toán
        int k;
        AlgorithmKmeans a;

        public frmThuatToan()
        {
            InitializeComponent();
        }

        private void frmThuatToan_Load(object sender, EventArgs e)
        {
            listEUs = new List<EncryptedUser>();
            LoadDataToListEUs();
            LoadDataToComboboxK();
        }

        private void LoadDataToComboboxK()
        {
            cbKValue.Items.Add(3);
            cbKValue.Items.Add(4);
            cbKValue.Items.Add(5);
            cbKValue.SelectedItem=3;
        }

        // ==> Method Load Data (EncryptedUsers) From SQLServer To ListEUs Of Algorithm K-mean
        private void LoadDataToListEUs()
        {
            try
            {
                //==> Đưa dữ liệu từ SQL Server vào DataTabe
                conn = new SqlConnection(strConnectionString);
                daUsers = new SqlDataAdapter("EXEC uspGetEncryptedUser", conn);
                dtUsers = new DataTable();
                dtUsers.Clear();
                daUsers.Fill(dtUsers);
                //==> Đưa dữ liệu từ DataTable vào ListEUs
                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    DataRow dr = dtUsers.Rows[i];
                    listEUs.Add(new EncryptedUser(
                        Convert.ToInt32(dr[0]), // -->UserID
                        dr[1].ToString(),       // -->UserName
                        Convert.ToInt32(dr[2]), // -->Sex
                        Convert.ToInt32(dr[3]), // -->Age
                        Convert.ToInt32(dr[4]), // -->Birthday
                        Convert.ToInt32(dr[5]), // -->Hometown
                        Convert.ToInt32(dr[6]), // -->NowLiving
                        Convert.ToInt32(dr[7]), // -->SoBanBe
                        Convert.ToInt32(dr[8]), // -->TrangThaiTinhCam
                        Convert.ToInt32(dr[9])));//-->Followers
                }
                /*
                dgvListOfCluster.DataSource=dtUsers;
                //--AutoSizeColumns For DataGridView
                dgvListOfCluster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                */
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không Lấy Được Nội Dung Từ SQLServer\n" +
                    "ErrorInformation: "+e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartAlgorithm_Click(object sender, EventArgs e)
        {
            this.k = Int32.Parse(cbKValue.SelectedItem.ToString());
            a = new AlgorithmKmeans(listEUs, k);
            a.runAlgorithm();
            dgvCenters.DataSource = new BindingSource(a.ListClusters.Select(c => c.CenterUser), null);
            dgvCenters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dgvCenters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCenters.CurrentRow.Index;
            txtSelectedCluster.Text = "Nhóm " + i;
            dgvUsers.DataSource = new BindingSource(a.ListClusters[i].ListUsers, null);
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnShowOriginalData_Click(object sender, EventArgs e)
        {
            var form = new FormLoadFromSQLServer();
            form.ShowDialog();
        }
    }
}
