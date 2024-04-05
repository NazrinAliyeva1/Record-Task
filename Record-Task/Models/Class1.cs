using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record_Task.Models
{
    internal record Class1
    {
        public string Name="XXX";
        public string Surname="YYY";
        public byte Age=0;
        public string Job="WWW";


        public Class1(string name, string surname, byte age, string job)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Job = job;

        }
    }
}
