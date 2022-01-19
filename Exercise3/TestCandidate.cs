using System;

namespace Exercise3
{
    class TestCandidate
    {
        static void Main(string[] args)
        {
            //Input n student
            int n;
            Console.WriteLine("Input the number student you want to input: ");
            n = int.Parse(Console.ReadLine());
            Candidate[] list = new Candidate[n];
            for (int i = 0; i<n;i++)
            {
                Console.WriteLine("\nInput the information for student {0}:", i+ 1);
                list[i] = new Candidate();
                list[i].InputInfor();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nInformation of the Student {0}: ", i + 1);
                list[i].Display();
            }
            //Find the student have a total mark > 15
            for (int i = 0; i< n;i++)
            {
                if (list[i].Totalmark() > 15)
                {
                    Console.WriteLine("\nThis is a candidates with total score greater than 15: ");
                    list[i].Display();
                }
            }
        }
    }
}
