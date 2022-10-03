using CustomCollection.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Collections
{
    class GroupCollection
    {
        Group[] Groups;

        public GroupCollection()
        {
            Groups = new Group[0];
        }

        public void Add(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }

        public Group Get(int index)
        {
            return Groups[index];
        }
    }
}
