using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading;
using System.Drawing;

namespace K_means
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>() { 1.0, 1.1, 1.2, 5.5, 5.7, 23.4, 23.6 };
            //---Chạy thuật toán với k = 3
            runAlgorithm(list, 3);
            Console.ReadKey();
        }

        static List<Cluster> runAlgorithm(List<double> list, int count)
        {
            var clusters = new List<Cluster>(count);
            //Sắp xếp list dữ liệu nếu có thể
            list.Sort();
            //Bước 1: Chọn các center cho mỗi cụm
            var step = (int)(list.Count() / (count));
            for (int i = 0; i < count; i++)
            {
                clusters.Add(new Cluster());
                clusters[i].Center = list[step + step * i - 1];
            }
            //Bước 2: Chạy thuật toán
            while (clusters.Sum(cluster => cluster.Change) > 0.01)
            {
                //Trước khi mỗi lượt chạy cập nhật lại cụm
                clusters.ForEach(cluster => {
                    if (cluster.List.Count() != 0)
                    {
                        cluster.updateCenter();  //Cập nhật trung tâm cụm
                        cluster.List.Clear();    //Xóa list thuộc cụm
                    }
                });
                //Với mỗi số thuộc list tất cả các số cần phân thành k cụm
                foreach (var num in list)
                {
                    int index = 0;
                    double minDistance = double.MaxValue;
                    for (int i = 0; i < count; i++)
                    {
                        var distance = Math.Abs(clusters[i].Center - num);//tính khoảng cách
                        if (distance < minDistance)
                        {
                            //lưu lại index của cluster sẽ chứa cái num có khoảng cách min
                            index = i;  
                            minDistance = distance;
                        }
                    }
                    clusters[index].List.Add(num);
                }
            }
            clusters.ForEach(cluster => cluster.showInfoCluster());//xem kết quả các cluster
            return clusters;
        }
    }

    class Cluster   //Đại diện cho 1 cụm
    {
        public List<double> List { get; set; }  //List các số thuộc cụm
        public double Average { get { return List.Average(); } } //Trung bình cộng của list
        public double Center { get; set; }  //Trung tâm cụm
        public double Change { get; private set; } //Độ thay đổi của Trung bình cộng và Trung tâm cũ
        public Cluster()
        {
            Change = double.MaxValue; 
            List = new List<double>();
        }
        public void updateCenter()  //Hàm tính Change đồng thời cập nhật Trung Tâm Cụm
        {
            Change = Math.Abs(Average - Center);
            Center = Average;
        }
        public void showInfoCluster()//Hàm show thông tin của Cluster 
        {
            //Show center
            Console.Write("Cluster with center is: " + Center + " \t- List In this cluster:");
            //show list of cluster
            foreach (var num in List)
            {
                Console.Write("" + num+", ");
            }
            Console.WriteLine();
        }
    }
}
