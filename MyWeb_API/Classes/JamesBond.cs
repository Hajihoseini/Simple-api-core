using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb_API.Classes
{
    public class JamesBond
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public JamesBond(int id,string name , int year)
        {
            Id = id;
            Name = name;
            Year = year;
        }
    }
}
