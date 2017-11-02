using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnMot.Classes_Kmeans_2
{
    public class AlgorithmKmeans2
    {
        //Fields
        private List<EncryptedUser2> listAllUsers;   // ==>List các User cần phân cụm
        private int k;                              // ==>k: Số cụm sẽ được phân thành
        public List<Cluster2> ListClusters = new List<Cluster2>();// ==> List chứa các cụm Cluster được phân cụm ra

        //Properties
        public List<EncryptedUser2> ListAllUsers { get => listAllUsers; set => listAllUsers = value; }
        public int K { get => k; set => k = value; }

        //Constructors
        public AlgorithmKmeans2(List<EncryptedUser2> listAllUsers, int k)
        {
            this.listAllUsers = listAllUsers;
            this.k = k;
        }
        public AlgorithmKmeans2()
        {
            listAllUsers = new List<EncryptedUser2>();
        }

        //Method (==>Thuật Toán K-mean<==)
        public List<Cluster2> runAlgorithm()
        {
            List<Cluster2> Clusters = new List<Cluster2>();
            GetCentersForClusters();//==>Chọn k centers cho k cluster theo quy luật hàng rào
            //Step 2: Chạy vòng lặp thuật toán K-means
            do
            {
                //--Cập nhật lại trung tâm cụm và xóa list trong cụm để phân nhóm lại các user cho các cụm
                ListClusters.ForEach(c =>
                { if (c.ListUsers.Count() != 0) { c.updateCenter(); c.ListUsers.Clear(); } });
                //--Dựa vào khoảng cách Cosine để góm các dữ liệu vào các cụm
                //--Nếu khoảng cách của dữ liệu đến center của cụm nào nhỏ nhất thì dữ liệu thuộc cụm đó 
                //--
                foreach (var u in listAllUsers) //Thao tác với mỗi User
                {
                    int index = 0;//--sẽ lưu index của Cụm Cluster sẽ chưa User này
                    double minDistance = double.MaxValue;
                    for (int i = 0; i < K; i++)
                    {
                        double distance = distanceTwoRecords(ListClusters[i].CenterUser, u);
                        if (distance < minDistance)
                        {
                            index = i;
                            minDistance = distance;
                        }
                    }
                    ListClusters[index].ListUsers.Add(u);
                }
                Console.WriteLine(ListClusters.Sum(c => c.Change).ToString());
            } while (ListClusters.Sum(c => c.Change).ToString() != "0.882813637419831");//--> trung bình cụm và center vẫn còn chênh lệch
            return Clusters;
        }

        //Method Lấy k trung tâm cho k cụm theo quy tắc
        public void GetCentersForClusters()
        {
            var step = (int)(listAllUsers.Count() / K);
            for (int i = 0; i < K; i++)
            {
                ListClusters.Add(new Cluster2());
                ListClusters[i].CenterUser = listAllUsers[step + step * i - 1];
            }
        }

        //Method tính khoảng cách giữa 2 records User trong dữ liệu
        //Khoảng cách Cosine
        public double distanceTwoRecords(EncryptedUser2 a, EncryptedUser2 b)
        {
            double varTusoCosine = 0;   //Tử số của khoảng cách cosine
            double varMausoCosine = 1;  //Mẫu số của khoảng cách cosine
            double x=0;
            double y=0;
            //int lenghtListAttrs = a.Attrs.Count;//có bao nhiêu Attrs trong 1 EncryptedUser
            for (int i = 0; i < 166; i++)
            {
                varTusoCosine += a.Attrs[i] * b.Attrs[i];
                // x1*y1 + x2*y2 + x3*y3 + x4*y4 +...+ x166*y166
                x += Math.Pow(a.Attrs[i], 2);//x1^2 + x2^2 + x3^2 +...+ x166^2
                y += Math.Pow(b.Attrs[i], 2);//y1^2 + y2^2 + y3^2 +...+ y166^2
            }
            varMausoCosine = Math.Sqrt(x) * Math.Sqrt(y);
            return varTusoCosine / varMausoCosine;
        }
    }
}
