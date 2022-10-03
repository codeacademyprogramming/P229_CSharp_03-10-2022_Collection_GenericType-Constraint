using CustomCollection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Collections
{
    class StudentCollection
    {
        Student[] Students;

        public StudentCollection()
        {
            Students = new Student[0];
        }

        public void Add(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public Student Get(int index)
        {
            return Students[index];
        }
    }
}
