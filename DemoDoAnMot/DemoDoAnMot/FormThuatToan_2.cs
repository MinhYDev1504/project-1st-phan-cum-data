using DemoDoAnMot.Classes_Kmeans_2;
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
    public partial class FormThuatToan_2 : Form
    {
        //Khai Báo Biến
        string strConnectionString = "Data Source=localhost;" +
            "Initial Catalog = FacebookUsers;" +
            "User ID =sa;Password=123456";//-- or Integrated Security = True
        SqlConnection conn = null;
        SqlDataAdapter daUsers = null;
        DataTable dtUsers = null;
        /*-------------------------*/
        List<EncryptedUser2> listEUs;    //--> List EncryptedUsers Của Thuật Toán
        int k;
        AlgorithmKmeans2 a;
        public FormThuatToan_2()
        {
            InitializeComponent();
        }

        private void btnShowOriginalData2_Click(object sender, EventArgs e)
        {
            var form = new FormLoadFromSQLServer_2();
            form.ShowDialog();
        }

        private void dgvCenters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvCenters.CurrentRow.Index;
            txtSelectedCluster.Text = "Nhóm " + i;
            dgvUsers.DataSource = new BindingSource(a.ListClusters[i].ListUsers, null);
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnStartAlgorithm_Click(object sender, EventArgs e)
        {
            this.k = Int32.Parse(cbKValue.SelectedItem.ToString());
            a = new AlgorithmKmeans2(listEUs, k);
            a.runAlgorithm();
            for (int i = 0; i < k; i++) a.ListClusters[i].CenterUser.UserName = "Nhóm " + i;
            dgvCenters.DataSource = new BindingSource(a.ListClusters.Select(c => c.CenterUser), null);
            dgvCenters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void FormThuatToan_2_Load(object sender, EventArgs e)
        {
            listEUs = new List<EncryptedUser2>();
            LoadDataToListEUs();
            LoadDataToComboboxK();
        }

        private void LoadDataToListEUs()
        {
            try
            {
                //==> Đưa dữ liệu từ SQL Server vào DataTabe
                conn = new SqlConnection(strConnectionString);
                daUsers = new SqlDataAdapter("EXEC uspGetEncryptedBinaryUser", conn);
                dtUsers = new DataTable();
                dtUsers.Clear();
                daUsers.Fill(dtUsers);
                //==> Đưa dữ liệu từ DataTable vào ListEUs
                for (int i = 0; i < dtUsers.Rows.Count; i++)
                {
                    DataRow dr = dtUsers.Rows[i];
                    List<Double> listAttrs = new List<double>();
                    for(int j = 2; j < dr.ItemArray.Length; j++)
                    {
                        listAttrs.Add(Convert.ToDouble(dr[j]));
                    }

                    listEUs.Add(new EncryptedUser2(
                        Convert.ToDouble(dr[0]),    // -->UserID
                        dr[1].ToString(),           // -->UserName
                        listAttrs));                //  --> listAttr
                }
                //foreach(EncryptedUser2 a in listEUs)
                //{
                //    a.showInfoConsole();
                //}
                
                dgvUsers.DataSource=dtUsers;
                //--AutoSizeColumns For DataGridView
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                
            }
            catch (SqlException e)
            {
                MessageBox.Show("Không Lấy Được Nội Dung Từ SQLServer\n" +
                    "ErrorInformation: " + e.Message, "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataToComboboxK()
        {
            cbKValue.Items.Add(2);
            cbKValue.Items.Add(3);
            cbKValue.Items.Add(4);
            cbKValue.Items.Add(5);
            cbKValue.Items.Add(6);
            cbKValue.Items.Add(7);
            cbKValue.SelectedItem = 5;
        }
    }
}
