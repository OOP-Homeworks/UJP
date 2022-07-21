using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string language;
        public string Tool { get => language; set => language = value; }

        public Programmer(string language)
        {
            this.language = language;
        }

        public void Create()
        {
            Console.WriteLine($"Hi! I'm a {language} programmer!");
        }

        public void Destory()
        {
            Console.WriteLine($"The {language} programmer needs some rest!");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper? other)
        {
            if (other != null)
            {
                return String.Compare(this.Tool, other.Tool);
            } else
            {
                throw new ArgumentException("Wrong argument");
            }
            
        }
    }
}
