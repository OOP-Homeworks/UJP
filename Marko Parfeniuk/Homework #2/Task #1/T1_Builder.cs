using System;

namespace Task_1
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public string Tool { get => tool; set => tool = value; }

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public void Create()
        {
            Console.WriteLine($"The builder created something with a {tool}");

        }

        public void Destory()
        {
            Console.WriteLine($"The builder destroyed something with a {tool}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
