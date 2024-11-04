using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory10
{
    public class File : Component
    {
        public File(string name) : base(name)
        {
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + Name);
        }
    }
}
