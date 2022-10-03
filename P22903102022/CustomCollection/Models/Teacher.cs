using CustomCollection.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Models
{
    class Teacher : Student
    {
        public string Name;
        public string Speciality;
        //public Group[] Groups;
        //public MyCollection<Group> Groups;

        public Teacher()
        {
            //Groups = new Group[0];
            //Groups = new MyCollection<Group>();
        }
    }
}
