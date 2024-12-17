using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_io
{
    internal class student
    {
        public string imie {  get; set; }
        public string nazwisko { get; set; }

        public student(string name, string surname)
        {
            this.imie = name;
            this.nazwisko = surname;
        }
    }
}
