using System;
using System.Collections.Generic;
using System.Text;

namespace _10d
{
    struct Teste
    { 
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }
    }
}
