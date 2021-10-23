using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctic1
{
    class Exam
    {
        public string subject_lesson;
        private int rating;
        DateTime dateExam;
        public Exam() { }
        public Exam(string sub_less,int rat,DateTime dat_exam)
        {
            subject_lesson = sub_less;
            rating = rat;
            dateExam = dat_exam;
        }

        public int Rating { get => rating; set => rating = value; }

        public override string ToString()
        {
            return $"\nsubject_lesson: {subject_lesson}\nrating: {rating}\ndate exam: {dateExam}";
        }
    }
}
