using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    interface Iitem
    {
        string Name { get; set; }
        List<string> Dependencies { get; }
        void AddDependency(string name);
    }
}
