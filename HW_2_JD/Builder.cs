using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        public Builder(string tool)
        {
            this.tool = tool;
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.tool, other.Tool);
        }
    }
}
