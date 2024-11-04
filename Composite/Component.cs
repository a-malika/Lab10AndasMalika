using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory10
{
    public abstract class Component
    {
        protected string Name;
        public Component(string name)
        {
            Name = name;
        }
        public abstract void Display(int depth);
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
