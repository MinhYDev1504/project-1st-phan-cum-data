using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DemoDoAnMot
{
    public partial class FormDuLieuLoadExcel : Form
    {
        String pathToFileExcel;// Variable Path To File Excel 
        public FormDuLieuLoadExcel()
        {
            InitializeComponent();
        }

        // -- Click On Button Open File
        private void btnOpen_Click(object sender, EventArgs e)
        {
            myOFD.Title = "Select file";
            myOFD.InitialDirectory = @"C:\";
            myOFD.Filter = "All File |*.*|Excel 2003 Files |*.xls|Excel 2007 File|*.xlsx";
            myOFD.FileName = "";
            myOFD.ShowDialog();
        }

        // -- Click Ok In Button SelectFile In OpenFileDialog
        private void myOFD_FileOk(object sender, CancelEventArgs e)
        {
            pathToFileExcel = myOFD.FileName;
            txtFileName.Text = pathToFileExcel.Substring(pathToFileExcel.LastIndexOf(@"\") + 1);
            List<string> sheets = getListSheet(pathToFileExcel);
            
        }

        // -- Method Get List Sheets Of File Excel
        private List<string> getListSheet(string pathToFileExcel)
        {
            try
            {
                List<string> sheets = new List<string>();
                string mycon = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", pathToFileExcel);
                OleDbConnection MyConnection = new OleDbConnection(mycon);
                MyConnection.Open();
                DataTable dt = MyConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //
                foreach (DataRow row in dt.Rows)
                {
                    sheets.Add(row["TABLE_NAME"].ToString());
                }
                cbSheet.DataSource = sheets;
                return sheets;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        // -- Button Load Data From CurrentSelectedSheet Of File Excel
        private void btnLoadToDgv_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MyConnection;
                DataSet dataSet;
                OleDbDataAdapter adapter;
                string query;
                string mycon;
                //
                mycon= string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", pathToFileExcel);
                MyConnection = new OleDbConnection(mycon);
                query = string.Format("select * from [{0}]", cbSheet.Text);
                adapter = new OleDbDataAdapter(query, mycon);
                //
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                dgvUsersProfile.DataSource = dataSet.Tables[0];
                //
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }

        }
    }
}
