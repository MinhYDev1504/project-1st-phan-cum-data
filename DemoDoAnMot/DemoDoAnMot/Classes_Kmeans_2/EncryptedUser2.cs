using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnMot.Classes_Kmeans_2
{
    public class EncryptedUser2
    {
        //Fields
        private double iDUser;      //mapping ==> UserID
        private String userName;    //mapping ==> UserName
        List<double> attrs;         //mapping ==> AllRemainAttributes (0 or 1)

        //Constructors
        public EncryptedUser2(double iDUser, string userName, List<double> attrs)
        {
            this.iDUser = iDUser;
            this.userName = userName;
            this.attrs = attrs;
        }
        public EncryptedUser2(List<double> attrs)
        {
            this.attrs = attrs;
        }
        public EncryptedUser2()
        {

        }

        //Properties
        public double IDUser { get => iDUser; set => iDUser = value; }
        public string UserName { get => userName; set => userName = value; }
        public List<double> Attrs { get => attrs; set => attrs = value; }

        //Methods
        public void showInfoConsole() // --> Test Result With Console Application
        {
            Console.Write(this.IDUser + "--");
            Console.Write(this.UserName + "--");
            foreach(double i in Attrs)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
