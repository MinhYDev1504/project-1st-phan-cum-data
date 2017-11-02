using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnMot.Classes_Kmeans_2
{
    public class Cluster2
    {
        //Fields
        private List<EncryptedUser2> listUsers;  // ==>list các User thuộc cụm Cluster     
        private EncryptedUser2 centerUser;       // ==>trung tâm center của cụm Cluster

        //Constructors
        public Cluster2(List<EncryptedUser2> listUsers, EncryptedUser2 centerUser)
        {
            this.listUsers = listUsers;
            this.centerUser = centerUser;
        }
        public Cluster2()
        {
            listUsers = new List<EncryptedUser2>();
        }

        //Properties
        public List<EncryptedUser2> ListUsers { get => listUsers; set => listUsers = value; }
        public EncryptedUser2 CenterUser { get => centerUser; set => centerUser = value; }
        public EncryptedUser2 AverageUser
        {
            get
            {
                //int lenghtListAttrs = ListUsers[0].Attrs.Count;//có bao nhiêu Attrs trong 1 EncryptedUser
                List<double> listAvgValues = new List<double>();
                for (int i = 0; i < 166; i++)
                {
                    listAvgValues.Add(ListUsers.Average(a => a.Attrs[i]));
                }
                return new EncryptedUser2(listAvgValues);
            }
        }
        //==> Khoảng thay đổi giữa Center cũ và Center mới sẽ được cập nhật vào lần kế tiếp
        public double Change
        {
            get { return new AlgorithmKmeans2().distanceTwoRecords(AverageUser, CenterUser); }
        }

        //-----------Methods------------
        //==> Hàm cập nhật Center sau mỗi lượt chạy thuật toán
        public void updateCenter()
        {
            this.CenterUser = this.AverageUser;
        }
        public EncryptedUser2 getAverage()
        {
            //int lenghtListAttrs = ListUsers[0].Attrs.Count;//có bao nhiêu Attrs trong 1 EncryptedUser
            List<double> listAvgValues = new List<double>();
            for (int i = 0; i < 166; i++)
            {
                listAvgValues.Add(ListUsers.Average(a => a.Attrs[i]));
            }
            return new EncryptedUser2(listAvgValues);
        }
    }
}
