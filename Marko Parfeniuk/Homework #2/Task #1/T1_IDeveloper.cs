using System;

namespace Task_1
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();
        void Destory();
        public string Tool { get; set; }
    }
}
