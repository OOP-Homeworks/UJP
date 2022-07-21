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
        
      public  string Tool
        {
            set { language = value; }
            get { return language; }
        }
        public Programmer(string language)
        {
            this.language = language;
        }
        public void Create()
        {
            Console.WriteLine($"Create a program in {language}");
        }
       public void Destroy()
        {
            Console.WriteLine($"Destroy a program in {language}");
        }
      
        
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool, other.Tool);
        }
    }
}
