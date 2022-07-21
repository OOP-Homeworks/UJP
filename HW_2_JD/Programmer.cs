using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HW_2
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        public string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        public Programmer(string language)
        {
            this.language = language;
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool, other.Tool);
        }
    }
}
