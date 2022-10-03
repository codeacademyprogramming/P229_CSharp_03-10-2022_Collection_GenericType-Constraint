using CustomCollection.Collections;
using CustomCollection.Models;
using System;

namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Vusal",
                SurName = "Zeynalov"
            };
            Student student1 = new Student
            {
                Name = "Vusal",
                SurName = "Zeynalov"
            };
            Student student2 = new Student
            {
                Name = "Vusal",
                SurName = "Zeynalov"
            };

            Group group = new Group
            {
                No = "P229"
            };

            //group.Students.Add(student);
            //group.Students.Add(student1);
            //group.Students.Add(student2);

            //Array.Resize(ref group.Students, group.Students.Length + 1);
            //group.Students[group.Students.Length - 1] = student;

            //Array.Resize(ref group.Students, group.Students.Length + 1);
            //group.Students[group.Students.Length - 1] = student1;

            //Array.Resize(ref group.Students, group.Students.Length + 1);
            //group.Students[group.Students.Length - 1] = student2;

            Teacher teacher = new Teacher
            {
                Name = "Hamid",
                Speciality = "Software Developer & Programming Instructor"
            };

            //teacher.Groups.Add(group);

            //Array.Resize(ref teacher.Groups, teacher.Groups.Length + 1);
            //teacher.Groups[teacher.Groups.Length - 1] = group;

            //Write<double>(15.2);
            //Write<Student>(student);
            string[] arr = { };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            arr[0] = "dsf";
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            MyCollection<string> myCollectionStr = new MyCollection<string>();

            for (int i = 0; i < myCollectionStr.Count; i++)
            {
                myCollectionStr[i] = "123";
                Console.WriteLine(myCollectionStr[9]);
            }

            foreach (var item in myCollectionStr)
            {

            }
        }

        //public static void Write<T>(T item) where T : class
        //{
        //    Console.WriteLine(item);
        //}

        //public void Write(int item)
        //{

        //}
    }
}
