using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab01_2
{
    class Person: IComparable
    {
        public int Age;
        public Person(int age)
        {
            this.Age = age;
        }
        public int CompareTo(object o)
        {
            Person p = o as Person;
            if (p != null)
                return this.Age.CompareTo(p.Age);
            else throw new Exception("Невозможно сравнить 2 объекта");
        }
    }
}
