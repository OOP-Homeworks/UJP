using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Builder : IDeveloper
    {
        string tool;
        public string Tool { get => tool; set => tool = value; }

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"I'm a builder and I'm using a {tool}");
        }

        public void Destory()
        {
            Console.WriteLine($"The builder did 2 home tasks with {tool}, so they need some rest!");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper? other)
        {
            if (other != null)
            {
                return String.Compare(this.Tool, other.Tool);
            }
            else
            {
                throw new ArgumentException("Wrong argument");
            }

        }
    }
}
