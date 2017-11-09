using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
    public abstract class Component
    {
        public string name;

        public Component(string Name)
        {
            name = Name;
        }
        public abstract void SetWeight();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract int GetWeight();
    }
}
