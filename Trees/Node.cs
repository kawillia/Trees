using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Node
    {
        public Node(Int32 value)
        {
            Value = value;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }
        public Int32 Value { get; set; }
    }
}
