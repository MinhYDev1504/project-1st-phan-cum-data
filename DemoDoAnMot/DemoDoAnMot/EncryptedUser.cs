using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnMot
{
    public class EncryptedUser
    {
        //Fields
        private double iDUser;
        private String userName;
        private double sex;
        private double age;
        private double birthday;
        private double hometown;
        private double nowLiving;
        private double friends;
        private double loveStatus;
        private double followers;

        //Constructors
        public EncryptedUser(double iDUser, string userName, double sex, double age, double birthday, double hometown, double nowLiving, double friends, double loveStatus, double followers)
        {
            this.IDUser = iDUser;
            this.UserName = userName;
            this.Sex = sex;
            this.Age = age;
            this.Birthday = birthday;
            this.Hometown = hometown;
            this.NowLiving = nowLiving;
            this.Friends = friends;
            this.LoveStatus = loveStatus;
            this.Followers = followers;
        }

        public EncryptedUser(double sex, double age, double birthday, double hometown, double nowLiving, double friends, double loveStatus, double followers)
        {
            //==> Encrypted User giả lập để làm center cho các Cluster
            this.Sex = sex;
            this.Age = age;
            this.Birthday = birthday;
            this.Hometown = hometown;
            this.NowLiving = nowLiving;
            this.Friends = friends;
            this.LoveStatus = loveStatus;
            this.Followers = followers;
        }

        public EncryptedUser()
        {

        }

        //Properties
        public double IDUser { get => iDUser; set => iDUser = value; }
        public string UserName { get => userName; set => userName = value; }
        public double Sex { get => sex; set => sex = value; }
        public double Age { get => age; set => age = value; }
        public double Birthday { get => birthday; set => birthday = value; }
        public double Hometown { get => hometown; set => hometown = value; }
        public double NowLiving { get => nowLiving; set => nowLiving = value; }
        public double Friends { get => friends; set => friends = value; }
        public double LoveStatus { get => loveStatus; set => loveStatus = value; }
        public double Followers { get => followers; set => followers = value; }
        
        //Methods
        public void showInfoConsole()
        {
            Console.Write(this.IDUser+"--");
            Console.Write(this.UserName + "--");
            Console.Write(this.Sex + "--");
            Console.Write(this.Age + "--");
            Console.Write(this.Birthday + "--");
            Console.Write(this.Hometown + "--");
            Console.Write(this.NowLiving + "--");
            Console.Write(this.Friends + "--");
            Console.Write(this.LoveStatus + "--");
            Console.WriteLine(this.Followers);
        }
    }
}
