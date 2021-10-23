using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctic1
{
    class Program
    {
      
        static void Main(string[] args)
        {
          
            Swich_on _On = 0;
            do
            {

            switch (_On)
            {
                case Swich_on.menu:
                            bool check  = true;
                        do
                        {
                            
                            Console.WriteLine("\nEnter name menu: ");
                            foreach (Swich_on it in Enum.GetValues(typeof(Swich_on)))
                                if(it != Swich_on.menu)Console.WriteLine(it);
                            try
                            {
                                _On = (Swich_on)Enum.Parse(typeof(Swich_on), Console.ReadLine());
                            }catch(Exception msg)
                            {
                                Console.WriteLine(msg.Message);
                            }
                            foreach (Swich_on it in Enum.GetValues(typeof(Swich_on)))
                                if (_On == it) check = false;
                            Console.Clear();
                        } while (check);
                    break;
                case Swich_on.practical:
                        Practic();
                        _On = Swich_on.menu;
                    break;
                case Swich_on.homeWork:
                        HomeWork();
                        _On = Swich_on.menu;
                    break;
                    default:
                    break;
            }
            } while (_On != Swich_on.exit);

           
        }
        public static void HomeWork() {
            Swich_on_HW _On_HW = Swich_on_HW.menu;
            Student student = new Student();
            Random rnd = new Random();
            do
            {
                switch (_On_HW)
                {
                    case Swich_on_HW.menu:
                        bool check = true;
                        do
                        {

                            Console.WriteLine("\nEnter name menu: ");
                            foreach (Swich_on_HW it in Enum.GetValues(typeof(Swich_on_HW)))
                                if (it != Swich_on_HW.menu) Console.WriteLine(it);
                            try
                            {
                                _On_HW = (Swich_on_HW)Enum.Parse(typeof(Swich_on_HW), Console.ReadLine());
                            }
                            catch (Exception msg)
                            {
                                Console.WriteLine(msg.Message);
                            }
                            foreach (Swich_on_HW it in Enum.GetValues(typeof(Swich_on_HW)))
                                if (_On_HW == it) check = false;

                            Console.Clear();
                        } while (check);
                        break;
                    case Swich_on_HW.addStudent:
                        Person stud = new Person();
                        Console.WriteLine("Add Student:");
                        Console.WriteLine("Enter first name: ");
                        stud.First_name = Console.ReadLine();
                        Console.WriteLine("Enter last name: ");
                        stud.Last_name = Console.ReadLine();
                        Console.WriteLine("Enter Gender name: ");
                        foreach (Gender it in Enum.GetValues(typeof(Gender)))
                            Console.WriteLine(it);
                        Console.WriteLine();
                        stud.Sex = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
                        Console.WriteLine("enter year birghtday: ");
                        int AddYears = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter mount birghtday: ");
                        int AddMount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter day birghtday: ");
                        int AddDay = Convert.ToInt32(Console.ReadLine());
                        stud.Birghtday = new DateTime(AddYears, AddMount, AddDay);
                        student.Person = new Person(stud);
                        Console.WriteLine("Enter num Group: ");
                        student.Num_grop = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter type Education: ");
                        foreach (Education it in Enum.GetValues(typeof(Education)))
                            Console.WriteLine(it);
                        Console.WriteLine();
                        student.Education = (Education)Enum.Parse(typeof(Education), Console.ReadLine());
                        Console.WriteLine("ADD STUDENT COMPLETE");
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.addStAuto:
                        student.Person = new Person("taras", "rubay", new DateTime(1991, 3, 10), Gender.Female);
                        student.Num_grop = 15;
                        int ind_edu = rnd.Next(0, Enum.GetNames(typeof(Education)).Length);
                        student.Education = (Education)ind_edu;
                        Console.WriteLine("AUTO ADD STUDENT COMPLETE");
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.toShortString:
                        Console.WriteLine(student.ToShortString());
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.toString:
                        Console.WriteLine(student.ToString());
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.findEducation:
                        foreach (Education it in Enum.GetValues(typeof(Education)))
                            Console.WriteLine($"Education: {it} - {student[it]} ");
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.addExam:
                        Console.WriteLine("Enter subject lesson: ");
                        string subj = Console.ReadLine();
                        Console.WriteLine("Enter rating: ");
                        int rat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("date exam 'DateTime.Now'");
                        student.AddExam(Exams: new Exam(subj, rat, new DateTime(DateTime.Now.Year,
                            DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)));
                        Console.WriteLine("ADD EXAM COMPLETE");
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.addExamAuto:
                        Console.WriteLine("enter number of exam: ");
                        int number_exam = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < number_exam; i++)
                        {
                            int rand_rating = rnd.Next(1, 12);
                            int ind_subj = rnd.Next(0, Enum.GetNames(typeof(RndExam)).Length);
                            student.AddExam(new Exam(Convert.ToString((RndExam)ind_subj), rand_rating, new DateTime(DateTime.Now.Year,
                                DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)));
                            Console.WriteLine($"ADD {i} Auto EXAM COMPLETE date exam 'DateTime.Now");
                        }
                        _On_HW = Swich_on_HW.menu;
                        break;
                    case Swich_on_HW.testTime:
                        Exam[,] people_td_ar = new Exam[3, 5];

                        Exam[] people_ar = new Exam[15];

                        Exam[][] people_ar_jac = new Exam[4][];
                        people_ar_jac[0] = new Exam[2];
                        people_ar_jac[1] = new Exam[3];
                        people_ar_jac[2] = new Exam[4];
                        people_ar_jac[3] = new Exam[6];


                        for (int i = 0; i < people_ar.Length; i++)
                        {
                            int rand_rating = rnd.Next(1, 12);
                            int ind_subj = rnd.Next(0, Enum.GetNames(typeof(RndExam)).Length);
                            people_ar[i] = new Exam(Convert.ToString((RndExam)ind_subj), rand_rating, new DateTime(DateTime.Now.Year,
                            DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                        }

                        for (int i = 0; i < people_td_ar.GetLength(0); i++)
                        {
                            for (int j = 0; j < people_td_ar.GetLength(1); j++)
                            {
                                int rand_rating = rnd.Next(1, 12);
                                int ind_subj = rnd.Next(0, Enum.GetNames(typeof(RndExam)).Length);
                                people_td_ar[i, j] = new Exam(Convert.ToString((RndExam)ind_subj), rand_rating, new DateTime(DateTime.Now.Year,
                            DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                
                            }
                        }

                        for (int i = 0; i < people_ar_jac.Length; i++)
                        {
                            for (int j = 0; j < people_ar_jac[i].Length; j++)
                            {
                                int rand_rating = rnd.Next(1, 12);
                                int ind_subj = rnd.Next(0, Enum.GetNames(typeof(RndExam)).Length);
                                people_ar_jac[i][j] = new Exam(Convert.ToString((RndExam)ind_subj), rand_rating, new DateTime(DateTime.Now.Year,
                            DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                            }
                        }


                        int time = Environment.TickCount;
                        Console.WriteLine($"start one dementional array ");
                        foreach (var item in people_ar)
                        {
                            Console.WriteLine(item.ToString());
                            Console.WriteLine();
                        }
                        Console.WriteLine($"\t\t\t\tstop one dementional array {Environment.TickCount - time}");


                        time = Environment.TickCount;
                        Console.WriteLine($"start two dementional array ");
                        foreach (var item in people_td_ar)
                        {
                            Console.WriteLine(item.ToString());
                            Console.WriteLine();
                        }
                        Console.WriteLine($"\t\t\t\tstop two dementional array {Environment.TickCount - time}");


                        time = Environment.TickCount;
                        Console.WriteLine($"start jacet array ");
                        for (int i = 0; i < people_ar_jac.Length; i++)
                        {
                            for (int j = 0; j < people_ar_jac[i].Length; j++)
                            {
                                Console.WriteLine(people_ar_jac[i][j]);
                            }
                        }
                        Console.WriteLine($"\t\t\t\tstop jacet array {Environment.TickCount - time}");


                        _On_HW = Swich_on_HW.menu;
                        break;
                    default:
                        break;
                }
            } while (_On_HW != Swich_on_HW.exit);
            
             
        }
        public enum RndExam : byte { math, history, cpp, biology, physics }
        public enum Education : byte { Bacelor, Specialist, Master }
        public enum Gender : byte { Male, Female }
        public enum Swich_on : byte { menu, practical, homeWork, exit }
        public enum Swich_on_HW : byte { menu, addStudent, addStAuto, toShortString, toString, findEducation
                , addExam, addExamAuto, testTime, exit }
        public static long count_Person;
        public static void Practic()
        {
            DateTime s = new DateTime(1991, 3, 10);

            Person[,] people_td_ar = new Person[3, 5];

            Person[] people_ar = new Person[15];

            Person[][] people_ar_jac = new Person[4][];
            people_ar_jac[0] = new Person[2];
            people_ar_jac[1] = new Person[3];
            people_ar_jac[2] = new Person[4];
            people_ar_jac[3] = new Person[6];


            for (int i = 0; i < people_ar.Length; i++)
            {
                people_ar[i] = new Person("Taras", "Rubay", s, (Gender)1);
            }

            for (int i = 0; i < people_td_ar.GetLength(0); i++)
            {
                for (int j = 0; j < people_td_ar.GetLength(1); j++)
                {
                    people_td_ar[i, j] = new Person("Taras", "Rubay", s, (Gender)1);
                }
            }

            for (int i = 0; i < people_ar_jac.Length; i++)
            {
                for (int j = 0; j < people_ar_jac[i].Length; j++)
                {
                    people_ar_jac[i][j] = new Person("Taras", "Rubay", s, (Gender)1);
                }
            }


            int time = Environment.TickCount;
            Console.WriteLine($"start one dementional array ");
            foreach (Person item in people_ar)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.WriteLine($"\t\t\t\tstop one dementional array {Environment.TickCount - time}");


            time = Environment.TickCount;
            Console.WriteLine($"start two dementional array ");
            foreach (Person item in people_td_ar)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.WriteLine($"\t\t\t\tstop two dementional array {Environment.TickCount - time}");


            time = Environment.TickCount;
            Console.WriteLine($"start jacet array ");
            for (int i = 0; i < people_ar_jac.Length; i++)
            {
                for (int j = 0; j < people_ar_jac[i].Length; j++)
                {
                    Console.WriteLine(people_ar_jac[i][j]);
                }
            }
            Console.WriteLine($"\t\t\t\tstop jacet array {Environment.TickCount - time}");



            Console.WriteLine();
            Console.WriteLine($"countPerson {count_Person}");
        }
    }
}
