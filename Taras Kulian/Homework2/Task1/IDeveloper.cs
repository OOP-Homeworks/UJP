using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();
        void Destory();
        public string Tool { get; set; }
    }
}
