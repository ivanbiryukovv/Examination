using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace examination.Models
{
    class DeansOffice
    {
        public List<Student> Students = new List<Student>();

        public void sortStudents(List<Student> students)
        {
            var size = students.Count;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (string.Compare(Students[j].surname, Students[j + 1].surname) > 0 
                        && string.Compare(Students[j].name, Students[j + 1].name) > 0)
                    {
                        var temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }

        public void saveToFile(List<Student> students)
        {
            string filePath = "data.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    sw.WriteLine($"{students[i].surname}, {students[i].name}, {students[i].number}");
                }
            }
        }
    }
}
