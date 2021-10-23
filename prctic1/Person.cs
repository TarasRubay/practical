using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctic1
{
    class Person
    {
        long idn_code;
        string first_name;
        string last_name;
        DateTime birghtday;
        Program.Gender sex;
       

        public string Idn_code { get {
                string num_id = idn_code.ToString();
                string id = new string('0', 10 - num_id.Length);
                return id + num_id;
            } }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Birghtday { get => birghtday; set => birghtday = value; }
        internal Program.Gender Sex { get => sex; set => sex = value; }

        public byte Age
        {
            get
            {
                TimeSpan a = DateTime.Now - birghtday;
                byte age = Convert.ToByte(((a.TotalMinutes / 60) / 24) / 365);
                return age;
            }
        }

        public Person(string first_name,string last_name,DateTime date,Program.Gender gender)
        {
            Program.count_Person += 1;
            this.first_name = first_name;
            this.last_name = last_name;
            birghtday = date;
            sex = gender;
            idn_code = Program.count_Person;
        }
        public Person() {
            
            Program.count_Person += 1;
        }
        public Person(Person person)
        {
            this.first_name = person.first_name;
            this.last_name = person.last_name;
            this.birghtday = person.birghtday;
            this.sex = person.sex;
            idn_code = person.idn_code;
        }
        public override string ToString()
        {
            string info = "first name: " + first_name + "\nlast name: " + last_name + "\nbirghtday: " + birghtday.ToString() + "\nsex: " + sex + "\nage: " + Age + "\nid code:" + Idn_code;
            return info;
        }
        public virtual string ToShortString()
        {
            string info = "first name: " + first_name + "\nlast name: " + last_name + "\nid code:" + Idn_code;
            return info;
        }
    }
}
