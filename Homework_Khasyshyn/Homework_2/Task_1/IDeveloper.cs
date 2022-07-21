using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
       
    }
}