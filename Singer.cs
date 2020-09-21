using System;
using System.Collections.Generic;
using System.Text;

namespace oop_615261018_w08
{
    class Singer
    {
        private string name;
        private string nickName;
        private string age;
        private string birthDay;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
        public Singer(string n, string nn, string a, string b)
        {
            this.name = n;
            this.nickName = nn;
            this.age = a;
            this.birthDay = b;

        }
        public override string ToString()
        {
            return this.Name + " " +
                 this.NickName + " " +
                 this.Age + " " +
                 this.BirthDay;

        }
    }
}