using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Builder: IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public string Tool
        {
            set
            {
                tool = value;
            }
            get 
            { 
                return tool; 
            }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }
       public void Create()
        {
            Console.WriteLine($"Build with a {tool}");
        }
       public void Destroy()
        {
            Console.WriteLine($"Destroy with a {tool}");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
