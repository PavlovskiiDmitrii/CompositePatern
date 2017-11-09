using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
    public class File : Component
    {
        public int weight { get; set; }

        public File(string name, int Weight)
            : base(name)
        {
            weight = Weight;
        }
        public override void SetWeight()
        {
            throw new NotImplementedException();
        }
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public override int GetWeight()
        {
            return weight;
        }
    }
}
