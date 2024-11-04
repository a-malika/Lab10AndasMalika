using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laboratory10
{
    public class Directory : Component
    {
        private List<Component> components;
        public Directory(string name) : base(name)
        {
            components = new List<Component>();
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + Name);
            foreach (var component in components)
            {
                component.Display(depth + 3);
            }
        }
        public override void Add(Component component)
        {
            components.Add(component);
        }
        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
