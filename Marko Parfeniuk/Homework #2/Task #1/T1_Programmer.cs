using System;

namespace Task_1
{
    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        string language;
        public string Tool { get => language; set => language = value; }

        public Programmer(string language)
        {
            this.language = language;
        }

        public void Create()
        {
            Console.WriteLine($"The programmer created something in a {language}");
        }

        public void Destory()
        {
            Console.WriteLine($"The programmer destroyed something in a {language}");
        }
 
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
