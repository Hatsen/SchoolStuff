using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();
            t.Insert(100);
            t.Insert(50);
            t.Insert(200);
            t.Insert(10);
            t.Insert(60);
            t.Insert(150);
            t.Insert(500);
            t.Print();
        }
    }
}
