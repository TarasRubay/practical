using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctic1
{
    class Student
    {
        Person person;
        Program.Education education;
        int num_grop;
        Exam[] exams = new Exam[0];
        public Student() { }
        public Student(Person person,Program.Education education,int num_group)
        {
            this.person = person;
            this.education = education;
            this.num_grop = num_group;
        }

        public int Num_grop { get => num_grop; set => num_grop = value; }
        internal Person Person { get => person; set => person = value; }
        internal Program.Education Education { get => education; set => education = value; }
        internal Exam[] Exams { get => exams; set => exams = value; }
        public double AverRating
        {
            get
            {
                if (exams.Length == 0)return 0;

                int sum = 0;
                foreach (var item in exams)
                {
                    sum += item.Rating;
                }
                return sum / exams.Length;
            }
            }
        public bool this[Program.Education education] {
            get {
                if (this.Education == education) return true;
                else return false;
            }
        }
        public void AddExam(params Exam[] Exams)
        {
            foreach (var item in Exams)
            {
            Array.Resize(ref exams, exams.Length + 1);
            exams[exams.Length - 1] = item;
            }
        }
        public override string ToString()
        {
            string rat = "";
            foreach (var item in exams)
            {
                rat += item.ToString();
            }
            if (rat.Length == 0) rat = "list empty";
            return $"Name student:  {Person.ToString()}\nEducation: {Education.ToString()}\nNumber Group {num_grop}\nList exam: {rat}";
        }
        public virtual string ToShortString()
        {
            return $"Name student:  {Person.ToString()}\nEducation: {Education.ToString()}\nNumber Group {num_grop}\nAverage exam: {AverRating}";
        }
    }
    
}
