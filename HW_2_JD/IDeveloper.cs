using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    interface IDeveloper: IComparable<IDeveloper>
    { 
        string Tool { get; set; }
        void Create(string name)
        {
            Console.Write( $"\n Developer create somehing with {name}!");
        }
        void Destroy( string name)
        {
            Console.Write($"\n Developer destroy project with {name}!");
        }

    }
}
