using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnMot
{
    public class Cluster
    {
        //Khai Báo Biến
        private List<EncryptedUser> listUsers;  // ==>list các User thuộc cụm Cluster     
        private EncryptedUser centerUser;       // ==>trung tâm center của cụm Cluster

        //Constructors
        public Cluster(List<EncryptedUser> listUsers, EncryptedUser centerUser)
        {
            this.ListUsers = listUsers;
            this.CenterUser = centerUser;
        }

        public Cluster()
        {
            listUsers = new List<EncryptedUser>();
        }

        //Properties
        public List<EncryptedUser> ListUsers { get => listUsers; set => listUsers = value; }
        public EncryptedUser CenterUser { get => centerUser; set => centerUser = value; }
        // ==>User ảo với các thuộc tính là trung bình cộng của các giá trị cùng thuộc tính của các User có trong list
        public EncryptedUser AverageUser { get { return new EncryptedUser(ListUsers.Average(a=>a.Sex),
            ListUsers.Average(a => a.Age),
            ListUsers.Average(a => a.Birthday),
            ListUsers.Average(a => a.Hometown),
            ListUsers.Average(a => a.NowLiving),
            ListUsers.Average(a => a.Friends),
            ListUsers.Average(a => a.LoveStatus),
            ListUsers.Average(a => a.Followers)); } }
        //==> Khoảng thay đổi giữa Center cũ và Center mới sẽ được cập nhật vào lần kế tiếp
        public double Change { get {return new AlgorithmKmeans().distanceTwoRecords(AverageUser,CenterUser); }}

        //-----------Methods------------
        //==> Hàm cập nhật Center sau mỗi lượt chạy thuật toán
        public void updateCenter()
        {
            this.CenterUser = this.AverageUser;
        }
        public EncryptedUser getAverage()
        {
            return new EncryptedUser(ListUsers.Average(a => a.Sex),
            ListUsers.Average(a => a.Age),
            ListUsers.Average(a => a.Birthday),
            ListUsers.Average(a => a.Hometown),
            ListUsers.Average(a => a.NowLiving),
            ListUsers.Average(a => a.Friends),
            ListUsers.Average(a => a.LoveStatus),
            ListUsers.Average(a => a.Followers));
        }
    }
}
