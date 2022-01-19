using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class Candidate
    {
        private int iD;
        private string name;
        private string year;
        private int math;
        private int literature;
        private int english;
        public Candidate()
        {

        }
        public Candidate(int iD,string name,string year,int math,int literature,int english)
        {
            this.iD = iD;
            this.name = name;
            this.year = year;
            this.math = math;
            this.literature = literature;
            this.english = english;
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Math
        {
            get { return math; }
            set { math = value; }
        }
        public int Literature
        {
            get { return literature; }
            set { literature = value; }
        }
        public int English
        {
            get { return english; }
            set { english = value; }
        }
        public void InputInfor()
        {
            Console.WriteLine("Input ID of student: ");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Input name of student: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input year of birth: ");
            Year = Console.ReadLine();
            Console.WriteLine("Input Math mark: ");
            Math = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Literature mark: ");
            Literature = int.Parse(Console.ReadLine());
            Console.WriteLine("Input English mark: ");
            English = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("ID of student: " + ID);
            Console.WriteLine("Name of Student: " + Name);
            Console.WriteLine("Year of Birth: " + Year);
            Console.WriteLine("Math mark: " + Math);
            Console.WriteLine("Literature mark: " + Literature);
            Console.WriteLine("English mark: " + English);
        }
        public double Totalmark()
        {
            return (Math + Literature + English);
        }
    }
}
