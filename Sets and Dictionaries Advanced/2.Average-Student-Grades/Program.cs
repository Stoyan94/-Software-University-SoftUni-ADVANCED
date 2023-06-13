using System;
using System.Linq;
using System.Collections.Generic;


namespace _2.Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            Dictionary<string,List<decimal>> studentsGrades = new Dictionary<string,List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split(" ");

                var studentName = studentsInfo[0];
                var studentGrade = decimal.Parse(studentsInfo[1]);

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades.Add(studentName, new List<decimal>());
                }

                studentsGrades[studentName].Add(studentGrade);

            }

            foreach (var studentName in studentsGrades)
            {
                Console.Write($"{studentName.Key} -> ");

                foreach (var studentGrade in studentName.Value)
                {                   
                    Console.Write($"{studentGrade:F2} ");
                }
                Console.WriteLine($"(avg: {studentName.Value.Average():f2})");
            }
        }
    }
}
